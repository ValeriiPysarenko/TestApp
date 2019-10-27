using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TestApp
{
   public class User
    {


       public enum AccountStatus
        {
            TRIAL,
            ACTIVE,
            SUSPENDED,
            CANCELLED,
            PREPAID
        }

        public enum Permissions
        {
            USER
        }
        public string Id { get; set; }
        public string Username { get; set; }
        public AccountStatus accountStatus { get; set; }
        public string ExpirationDate { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName {  get; set;  }
        public string PhoneNumber { get; set; }
        public string TimeZone { get; set; }
        public string OrganizationId { get; set; }
        public string SignupClient { get; set; }
        public string DateCreated { get; set; }
        public string LastLoginDate { get; set; }
        public bool Active { get; set; }
        public bool Human { get; set; }
        public IList<Permissions> permissions { get; set; }
        public IList<string> TeamIds { get; set; }
        public string PartnerId { get; set; }
        public string ProfilePicture { get; set; }
        public string Description { get; set; }
        public string Alias { get; set; }
        public string InstagramProfileId { get; set; }

        public User(string id, string username, AccountStatus accountStatus, string expirationDate, string email, string firstName, string lastName, string phoneNumber, string timeZone, string organizationId, string signupClient, string dateCreated, string lastLoginDate, bool active, bool human, User.Permissions[] permissions, string[] teamIds, string partnerId, string profilePicture, string description, string alias, string instagramProfileId)
        {
            this.Id = id;
            this.Username = username;
            this.accountStatus = accountStatus;
            this.ExpirationDate = expirationDate;
            this.Email = email;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.TimeZone = timeZone;
            this.OrganizationId = organizationId;
            this.SignupClient = signupClient;
            this.DateCreated = dateCreated;
            this.LastLoginDate = lastLoginDate;
            this.Active = active;
            this.Human = human;
            this.permissions = permissions;
            this.TeamIds = teamIds;
            this.PartnerId = partnerId;
            this.ProfilePicture = profilePicture;
            this.Description = description;
            this.Alias = alias;
            this.InstagramProfileId = instagramProfileId;
        }

    }
}