﻿namespace DiscogsClient
{
   public class DiscogsClient 
   {
        private readonly OAuthConsumerInformation _OAuthConsumerInformation;
        private const string _UrlBase = "http://api.discogs.com/";

        public DiscogsClient(OAuthConsumerInformation oAuthConsumerInformation) 
        {
            _OAuthConsumerInformation = oAuthConsumerInformation;
        }
    }
}
