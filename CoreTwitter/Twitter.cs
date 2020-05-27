using LinqToTwitter;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreTwitter
{
    public class Twitter
    {
        private SingleUserAuthorizer authorizer { get; set; } = new SingleUserAuthorizer();

        public Twitter(string CKey, string CSecret, string AToken, string ATokenSecret)
        {
            authorizer =
            new SingleUserAuthorizer
            {
                CredentialStore = new SingleUserInMemoryCredentialStore
                {
                    ConsumerKey = CKey,
                    ConsumerSecret = CSecret,
                    AccessToken = AToken,
                    AccessTokenSecret = ATokenSecret
                }
            };
    }

        public async void Tweet(string Message)
        {
            try
            {
                var twitterContext = new TwitterContext(authorizer);

                await twitterContext.TweetAsync(Message);
            }
            catch(Exception ex)
            {

            }
        }

        public async void TweetWithPngImage(string Message, string ImageFilePath) // todo convert param data type
        {
            var twitterContext = new TwitterContext(authorizer);

            MediaUploadResult UploadResult = await UploadPngImage(ImageFilePath);

            if (UploadResult.Succeeded)
            {
                await twitterContext.TweetAsync(Message, Enumerable.Repeat(UploadResult.MediaId, 1));
            }
            else
            {
                await twitterContext.TweetAsync(Message);
            }


        }
        public async Task<MediaUploadResult> UploadPngImage(string ImageFilePath) // todo update param data type
        {

            try
            {
                var twitterContext = new TwitterContext(authorizer);

                Media media = await twitterContext.UploadMediaAsync(File.ReadAllBytes(ImageFilePath), "image/png", "tweet_image");

                if (media.MediaID > 0)
                {
                    return new MediaUploadResult(true, media.MediaID);
                }
                else
                {
                    return new MediaUploadResult(false, 0);
                }

            }
            catch (Exception ex)
            {
                return new MediaUploadResult(false, 0);
            }
            //var twitterContext = new TwitterContext(authorizer);

            //Media media = await twitterContext.UploadMediaAsync(File.ReadAllBytes(ImageFilePath), "image/png", "tweet_image");


            //Media mediaStatusResponse = null;
            //do
            //{
            //    if (mediaStatusResponse != null)
            //    {
            //        int checkAfterSeconds = mediaStatusResponse?.ProcessingInfo?.CheckAfterSeconds ?? 0;
            //        Console.WriteLine($"Twitter video testing in progress - waiting {checkAfterSeconds} seconds.");
            //        await Task.Delay(checkAfterSeconds * 1000);
            //    }

            //    mediaStatusResponse =
            //        await
            //        (from stat in twitterContext.Media
            //         where stat.Type == MediaType.Status &&
            //               stat.MediaID == media.MediaID
            //         select stat)
            //        .SingleOrDefaultAsync();
            //} while (mediaStatusResponse?.ProcessingInfo?.State == MediaProcessingInfo.InProgress);

            //if (mediaStatusResponse?.ProcessingInfo?.State == MediaProcessingInfo.Succeeded)
            //{
            //    return new MediaUploadResult(true, media.MediaID);
            //}
            //else
            //{

            //}
        }


    }

    public class MediaUploadResult
    {
        public bool Succeeded = false;
        public ulong MediaId = 0;

        public MediaUploadResult(bool _Succeed, ulong _MediaId)
        {
            Succeeded = _Succeed;
            MediaId = _MediaId;
        }
    }
}