using JWTNet.Examples;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JWTNet.API.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class TestFileController : ControllerBase
    {

        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {

                var exporter = new Exporter();
                var result = exporter.Export();
                var dto = new ResultDto();
                dto.Data = result;

                //message
                HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new MemoryStream(result);

                resp.Content = new ByteArrayContent(result);
                resp.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                resp.Content.Headers.ContentDisposition.FileName = "descarga.xlsx";
                //resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                resp.Content.Headers.Add("x-filename", "descarga.xlsx"); //We will use this below


                return resp;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("getdto")]
        [HttpGet]
        public ResultDto GetDto()
        {
            try
            {

                var exporter = new Exporter();
                var result = exporter.Export();
                var dto = new ResultDto();
                dto.Data = result;

                //message
                HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new MemoryStream(result);

                resp.Content = new ByteArrayContent(result);
                resp.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                resp.Content.Headers.ContentDisposition.FileName = "descarga.xlsx";
                //resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                resp.Content.Headers.Add("x-filename", "descarga.xlsx"); //We will use this below


                return dto;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        [Route("getarray")]
        [HttpPost]
        public FileContentResult GetArray()
        {
            try
            {

                var exporter = new Exporter();
                var result = exporter.Export();
                var dto = new ResultDto();
                dto.Data = result;

                //message
                HttpResponseMessage resp = new HttpResponseMessage(HttpStatusCode.OK);
                var stream = new MemoryStream(result);

                resp.Content = new ByteArrayContent(result);
                resp.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");
                resp.Content.Headers.ContentDisposition.FileName = "descarga.xlsx";
                //resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                resp.Content.Headers.ContentType = new MediaTypeHeaderValue("application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");

                resp.Content.Headers.Add("x-filename", "descarga.xlsx"); //We will use this below


                return new FileContentResult(result, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}

