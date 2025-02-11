using Umbraco.Cms.Core.Models.ContentEditing;
using Umbraco.Cms.Core.Web;

namespace Umbraco.Cms.Core.Notifications
{
    public class SendingUserNotification : INotification
    {
        public IUmbracoContext UmbracoContext { get; }

        public UserDisplay User { get; }

        public SendingUserNotification(UserDisplay user, IUmbracoContext umbracoContext)
        {
            User = user;
            UmbracoContext = umbracoContext;
        }
    }
}
