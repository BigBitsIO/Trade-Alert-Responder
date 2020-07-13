using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL;
using WordPressPCL.Models;

namespace CoreWordPress
{
    public class WordPress
    {

        // Properties
        private string URI { get; set; }
        private string User { get; set; }
        private string Password { get; set; }

        private WordPressClient Client = null;

        // Constructor
        public WordPress(string _URI, string _User, string _Password)
        {

            URI = _URI;
            User = _User;
            Password = _Password;

            Client = GetClient();
            SetAuth();
        }

        public WordPressClient GetClient()
        {
            WordPressClient TheClient = new WordPressClient(URI);
            return TheClient;
        }

        public bool IsTokenValid()
        {
            // check if authentication has been successful
            return Client.IsValidJWToken().Result;
        }

        public void SetAuth()
        {
            Client.AuthMethod = AuthMethod.JWT;
            Client.RequestJWToken(User, Password);
            var IsValid = Client.IsValidJWToken().Result;
        }

        public async Task<Post> CreatePost(string Title, string PostHTML, List<string> Tags, List<string> Categories, string FeatureImageURL)
        {
            var MediaPull = await Client.Media.GetAll();
            List<MediaItem> Media = MediaPull.ToList();



            var Post = new Post()
            {
                Title = new Title(Title),
                Content = new Content(PostHTML),
                Tags = await GetTagIDArrayAsync(Tags),
                Categories = await GetCategoryIDArrayAsync(Categories),
                FeaturedMedia = await GetMediaID(await CreateMediaFromURLAsync(FeatureImageURL, Title))
            };

            if (IsTokenValid())
            {
                var CreatedPost = await Client.Posts.Create(Post);
                return CreatedPost;
            }
            else
            {
                return null;
            }
        }

        private async Task<int?> GetMediaID(MediaItem Media)
        {
            return Media.Id;
        }

        private async Task<MediaItem> CreateMediaFromURLAsync(string FeatureImageURL, string FeatureImageTitle)
        {
            if (IsTokenValid())
            {
                var req = System.Net.WebRequest.Create(FeatureImageURL);

                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SocialAutomator"))
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SocialAutomator");

                FeatureImageTitle = ReplaceInvalidChars(FeatureImageTitle);

                string FileLoc = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/SocialAutomator/" + FeatureImageTitle + ".jpg";

                WebClient webClient = new WebClient();
                webClient.DownloadFile(FeatureImageURL, FileLoc);


                return await Client.Media.Create(FileLoc, FeatureImageTitle + ".jpg");

            }
            else
            {
                return null;
            }
        }

        public async Task<Tag> CreateTagAsync(string Name)
        {
            // returns created tag
            var Tag = new Tag()
            {
                Name = Name
            };
            if (IsTokenValid())
            {
                return await Client.Tags.Create(Tag);
            }
            else
            {
                return null;
            }
        }

        public async Task<int[]> GetTagIDArrayAsync(List<string> Tags)
        {
            List<int> TagIDs = new List<int>();
            var AllTags = await Client.Tags.GetAll(false, true);

            foreach (string s in Tags)
            {
                string fs = s.Replace(" ", "-");
                // if it exists, add id to list, if not, create and then add id
                if (AllTags.Any(a => a.Name == fs || a.Slug == fs.ToLower()))
                {
                    TagIDs.Add(AllTags.Where(a => a.Name == fs || a.Slug == fs.ToLower()).FirstOrDefault().Id);
                }
                else
                {
                    TagIDs.Add(CreateTagAsync(s).Id);
                }

            }

            return TagIDs.ToArray();
        }

        public async Task<Category> CreateCategoryAsync(string Name)
        {
            // returns created tag
            var Category = new Category()
            {
                Name = Name
            };
            if (IsTokenValid())
            {
                return await Client.Categories.Create(Category);
            }
            else
            {
                return null;
            }
        }

        public async Task<int[]> GetCategoryIDArrayAsync(List<string> Categories)
        {
            List<int> CategoryIDs = new List<int>();
            var AllCategories = await Client.Categories.GetAll(false, true);

            foreach (string s in Categories)
            {
                string fs = s.Replace(" ", "-");
                // if it exists, add id to list, if not, create and then add id
                if (AllCategories.Any(a => a.Name == fs || a.Slug == fs.ToLower()))
                {
                    CategoryIDs.Add(AllCategories.Where(a => a.Name == fs || a.Slug == fs.ToLower()).FirstOrDefault().Id);
                }
                else
                {
                    CategoryIDs.Add(CreateCategoryAsync(s).Id);
                }

            }

            return CategoryIDs.ToArray();
        }

        public async Task<List<Post>> GetAllPosts()
        {
            return Client.Posts.GetAll(false, true).Result.ToList();
        }

        public string ReplaceInvalidChars(string filename)
        {
            return string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
        }

    }
}
