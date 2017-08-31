/*
 * IoT Aggregator API
 *
 * Sample API for aggregating data from multiple IoT devices and returning stored running averages.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using HistorianService.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HistorianService.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class DefaultApiController : Controller
    { 

        /// <summary>
        /// Add data generated from a device to the aggregator
        /// </summary>
        /// <remarks>Adds a data point from an IoT device. The aggregator selects the historian service, posts data to it, and receives the running average. Then updates its store for the history of running averages by device id and type.</remarks>
        /// <param name="deviceType">Device type</param>
        /// <param name="deviceId">Device ID</param>
        /// <param name="dataPointId">Each data point needs to have a unique ID</param>
        /// <param name="value">Value registered by the device.</param>
        /// <response code="201">Data added successfully.</response>
        /// <response code="401">Invalid input parameter.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpPost]
        [Route("/v1/deviceData/{deviceType}/{deviceId}")]
        [SwaggerOperation("AddDeviceData")]
        public virtual void AddDeviceData([FromRoute]string deviceType, [FromRoute]string deviceId, [FromQuery]string dataPointId, [FromQuery]float? value)
        { 
            throw new NotImplementedException();
        }


        /// <summary>
        /// Get the running averages of a device type given a date range.
        /// </summary>
        /// <remarks>Returns the running average of a device type given a date range, averaged by the minute.</remarks>
        /// <param name="deviceType">Device type</param>
        /// <param name="fromTime">Start of the date range.</param>
        /// <param name="toTime">End of the date range.</param>
        /// <response code="200">Running averages per minute</response>
        /// <response code="400">Invalid input parameter.</response>
        /// <response code="500">An unexpected error occurred.</response>
        [HttpGet]
        [Route("/v1/averageByDeviceType/{deviceType}")]
        [SwaggerOperation("AverageByDeviceTypeDeviceTypeGet")]
        [SwaggerResponse(200, type: typeof(List<InlineResponse200>))]
        public virtual IActionResult AverageByDeviceTypeDeviceTypeGet([FromRoute]string deviceType, [FromQuery]DateTime? fromTime, [FromQuery]DateTime? toTime)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<InlineResponse200>>(exampleJson)
            : default(List<InlineResponse200>);
            return new ObjectResult(example);
        }
    }
}
