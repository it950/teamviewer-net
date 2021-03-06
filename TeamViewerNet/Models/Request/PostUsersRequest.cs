﻿namespace TeamViewerNet.Models.Request
{
    public class PostUsersRequest : BaseRequestModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string permissions { get; set; }
        public string name { get; set; }
        public string language { get; set; }
    }
}
