using NotifierMobile.Utils;

namespace NotifierMobile.Enums
{
    public enum RequestType
    {
        [HttpRequestAttr(URL = APIInterface.GET_URL, Method = "GET")]
        GET_ALL,
        [HttpRequestAttr(URL = APIInterface.GET_URL, Method = "GET")]
        GET,
        [HttpRequestAttr(URL = APIInterface.ADD_URL, Method = "POST")]
        ADD,
        [HttpRequestAttr(URL = APIInterface.UPDATE_URL, Method = "PUT")]
        UPDATE,
        [HttpRequestAttr(URL = APIInterface.MARKREAD_URL, Method = "PUT")]
        MARK_AS_READ,
        [HttpRequestAttr(URL = APIInterface.DELETE_URL, Method = "DELETE")]
        DELETE
    }
}
