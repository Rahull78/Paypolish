﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayPolish.DataAccessLayer;
using PayPolish.Models;
using System.Data;
using System.Net;
using System.Text.Json.Serialization;

namespace PayPolish.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        [HttpGet("GetMasterData")]
        public List<MasterModel> GetMasterData()
        {
            bool status;
            MasterDataAccess MDA = new MasterDataAccess();
            List<MasterModel> master =  MDA.GetMasterData(out status);
            if(status == false)
            {
                /*return new StatusCodeResult(StatusCodes.Status500InternalServerError);*/
            }
            return master;
        }

        [HttpPost("AddMasterData")]
        public bool AddMasterData([FromBody] MasterModel data)
        {
            bool status;
            MasterDataAccess MDA = new MasterDataAccess();
            bool master = MDA.AddMasterData(data,out status);
            if (status == false)
            {
                /*return new StatusCodeResult(StatusCodes.Status500InternalServerError);*/
            }
            return master;
        }


        [HttpPost("EditMasterData")]
        public bool EditMasterData([FromBody] MasterModel data)
        {
            bool status;
            MasterDataAccess MDA = new MasterDataAccess();
            bool master = MDA.EditMasterData(data, out status);
            if (status == false)
            {
                /*return new StatusCodeResult(StatusCodes.Status500InternalServerError);*/
            }
            return master;
        }


        [HttpPost("DeleteMasterData")]
        public bool DeleteMasterData([FromBody] MasterModel data)
        {
            bool status;
            MasterDataAccess MDA = new MasterDataAccess();
            bool master = MDA.DeleteMasterData(data, out status);
            if (status == false)
            {
                /*return new StatusCodeResult(StatusCodes.Status500InternalServerError);*/
            }
            return master;
        }


        [HttpPost("FilterMasterData")]
        public List<MasterModel> FilterMasterData([FromBody] DateModel data)
        {
            bool status;
            MasterDataAccess MDA = new MasterDataAccess();
            List<MasterModel> master = MDA.FilterMasterData(data, out status);
            if (status == false)
            {
                /*return new StatusCodeResult(StatusCodes.Status500InternalServerError);*/
            }
            return master;
        }


        [HttpPost("FilterMasterByDate")]
        public List<MasterModel> FilterMasterByDate([FromBody] DateModel data)
        {
            bool status;
            MasterDataAccess MDA = new MasterDataAccess();
            List<MasterModel> master = MDA.FilterMasterByDate(data, out status);
            if (status == false)
            {
                /*return new StatusCodeResult(StatusCodes.Status500InternalServerError);*/
            }
            return master;
        }
    }
}
