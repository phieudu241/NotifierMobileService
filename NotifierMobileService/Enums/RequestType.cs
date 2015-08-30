using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NotifierMobile.Utils;

namespace NotifierMobile.Enums
{
    public enum RequestType
    {
        [HttpRequestAttr(URL = APIInterface.GET_URL, Method = "POST")]
        GET_ALL,
        [HttpRequestAttr(URL = APIInterface.GET_URL, Method = "POST")]
        GET,
        [HttpRequestAttr(URL = APIInterface.ADD_URL, Method = "POST")]
        ADD,
        [HttpRequestAttr(URL = APIInterface.UPDATE_URL, Method = "POST")]
        UPDATE,
        [HttpRequestAttr(URL = APIInterface.MARKREAD_URL, Method = "POST")]
        MARK_AS_READ,
        [HttpRequestAttr(URL = APIInterface.DELETE_URL, Method = "POST")]
        DELETE
    }
}
