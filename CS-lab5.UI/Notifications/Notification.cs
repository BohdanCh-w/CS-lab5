using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_lab5.UI.Notifications {
    public enum NotificationType {
        INFO,
        WARNING,
        ERROR,
        __UnexpectedType
    }

    public class Notification {
        public string Title { get; set; }
        public string Message { get; set; }
        public NotificationType Type { get; set; }

        public Notification(string title, string message, NotificationType type) {
            Title = title;
            Message = message;
            Type = type;
        }    
    }
}
