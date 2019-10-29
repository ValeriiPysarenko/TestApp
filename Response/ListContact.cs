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
    public class ListContact
    {


        public enum Gender
        {
            MALE,
            FEMALE,
            OTHER,
            UNKNOWN
        }
        public IList<Sharing> sharing { get; set; }
        public string contactType { get; set; }
        public string companyName { get; set; }
        public bool enrich { get; set; }
        public bool sfdcDuplicate { get; set; }
        public bool sfdcEnrich { get; set; }
        public string clientId { get; set; }
        public string source { get; set; }
        public IList<Address> addresses { get; set; }
        public IList<EmailContact> emails { get; set; }
        public IList<TelephoneContact> phoneNumbers { get; set; }
        public string prefix { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public string middleName { get; set; }
        public string suffix { get; set; }
        public string salutation { get; set; }
        public Gender gender { get; set; }
        public IList<string> restrictions { get; set; }
        public string assignedTo { get; set; }
        public IList<WebsiteBasicInfo> websites { get; set; }
        public IList<string> tags { get; set; }
        public IList<Profile> profiles { get; set; }
        public IList<MinimalListStatus> lists { get; set; }
        public string profileUrlstring { get; set; }
        public IList<MetaReference> metaRefs { get; set; }
        public IList<CustomField> customFields { get; set; }
        public IList<Segment> segments { get; set; }
        private string organizationId { get; set; }
        private string creatorId { get; set; }
        private int leadscore { get; set; }
        private string currentStatus { get; set; }

        private int currentStatusDuration { get; set; }
        private string lastInteraction { get; set; }
        public IList<StatusCount> interactions { get; set; }
        public IList<BaseDatapointAnswer> answers { get; set; }
        private string displayName { get; set; }
        public IList<LightweightContact> relatedTo { get; set; }
        private string id { get; set; }
        private string birthday { get; set; }
        private string snoozedUntilstring { get; set; }
        private string nationality { get; set; }
        private string locale { get; set; }
        public IList<Picture> pictures { get; set; }
        private string updated { get; set; }
        private string created { get; set; }
        private string profilePicture { get; set; }
        private bool favorite { get; set; }

        public ListContact(IList<Sharing> sharing, string contactType, string companyName, bool enrich, bool sfdcDuplicate, bool sfdcEnrich, string clientId, string source, IList<Address> addresses, IList<EmailContact> emails, IList<TelephoneContact> phoneNumbers, string prefix, string firstName, string lastName, string title, string middleName, string suffix, string salutation, Gender gender, IList<string> restrictions, string assignedTo, IList<WebsiteBasicInfo> websites, IList<string> tags, IList<Profile> profiles, IList<MinimalListStatus> lists, string profileUrlstring, IList<MetaReference> metaRefs, IList<CustomField> customFields, IList<Segment> segments, string organizationId, string creatorId, int leadscore, string currentStatus, int currentStatusDuration, string lastInteraction, IList<StatusCount> interactions, IList<BaseDatapointAnswer> answers, string displayName, IList<LightweightContact> relatedTo, string id, string birthday, string snoozedUntilstring, string nationality, string locale, IList<Picture> pictures, string updated, string created, string profilePicture, bool favorite)
        {
            this.sharing = sharing;
            this.contactType = contactType;
            this.companyName = companyName;
            this.enrich = enrich;
            this.sfdcDuplicate = sfdcDuplicate;
            this.sfdcEnrich = sfdcEnrich;
            this.clientId = clientId;
            this.source = source;
            this.addresses = addresses;
            this.emails = emails;
            this.phoneNumbers = phoneNumbers;
            this.prefix = prefix;
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;
            this.middleName = middleName;
            this.suffix = suffix;
            this.salutation = salutation;
            this.gender = gender;
            this.restrictions = restrictions;
            this.assignedTo = assignedTo;
            this.websites = websites;
            this.tags = tags;
            this.profiles = profiles;
            this.lists = lists;
            this.profileUrlstring = profileUrlstring;
            this.metaRefs = metaRefs;
            this.customFields = customFields;
            this.segments = segments;
            this.organizationId = organizationId;
            this.creatorId = creatorId;
            this.leadscore = leadscore;
            this.currentStatus = currentStatus;
            this.currentStatusDuration = currentStatusDuration;
            this.lastInteraction = lastInteraction;
            this.interactions = interactions;
            this.answers = answers;
            this.displayName = displayName;
            this.relatedTo = relatedTo;
            this.id = id;
            this.birthday = birthday;
            this.snoozedUntilstring = snoozedUntilstring;
            this.nationality = nationality;
            this.locale = locale;
            this.pictures = pictures;
            this.updated = updated;
            this.created = created;
            this.profilePicture = profilePicture;
            this.favorite = favorite;
        }


    }
}