//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custodians
{
    using System;
    using System.Collections.Generic;
    
    public partial class DNN_Portals
    {
        public DNN_Portals()
        {
            this.DNN_AnonymousUsers = new HashSet<DNN_AnonymousUsers>();
            this.DNN_Files = new HashSet<DNN_Files>();
            this.DNN_Folders = new HashSet<DNN_Folders>();
            this.DNN_Modules = new HashSet<DNN_Modules>();
            this.DNN_PortalAlias = new HashSet<DNN_PortalAlias>();
            this.DNN_PortalDesktopModules = new HashSet<DNN_PortalDesktopModules>();
            this.DNN_Profile = new HashSet<DNN_Profile>();
            this.DNN_ProfilePropertyDefinition = new HashSet<DNN_ProfilePropertyDefinition>();
            this.DNN_RoleGroups = new HashSet<DNN_RoleGroups>();
            this.DNN_Roles = new HashSet<DNN_Roles>();
            this.DNN_SiteLog = new HashSet<DNN_SiteLog>();
            this.DNN_Skins = new HashSet<DNN_Skins>();
            this.DNN_SystemMessages = new HashSet<DNN_SystemMessages>();
            this.DNN_Tabs = new HashSet<DNN_Tabs>();
            this.DNN_Urls = new HashSet<DNN_Urls>();
            this.DNN_UrlTracking = new HashSet<DNN_UrlTracking>();
            this.DNN_UserPortals = new HashSet<DNN_UserPortals>();
            this.DNN_UsersOnline = new HashSet<DNN_UsersOnline>();
            this.DNN_Vendors = new HashSet<DNN_Vendors>();
        }
    
        public int PortalID { get; set; }
        public string PortalName { get; set; }
        public string LogoFile { get; set; }
        public string FooterText { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public int UserRegistration { get; set; }
        public int BannerAdvertising { get; set; }
        public Nullable<int> AdministratorId { get; set; }
        public string Currency { get; set; }
        public decimal HostFee { get; set; }
        public int HostSpace { get; set; }
        public Nullable<int> AdministratorRoleId { get; set; }
        public Nullable<int> RegisteredRoleId { get; set; }
        public string Description { get; set; }
        public string KeyWords { get; set; }
        public string BackgroundFile { get; set; }
        public System.Guid GUID { get; set; }
        public string PaymentProcessor { get; set; }
        public string ProcessorUserId { get; set; }
        public string ProcessorPassword { get; set; }
        public Nullable<int> SiteLogHistory { get; set; }
        public Nullable<int> HomeTabId { get; set; }
        public Nullable<int> LoginTabId { get; set; }
        public Nullable<int> UserTabId { get; set; }
        public string DefaultLanguage { get; set; }
        public int TimezoneOffset { get; set; }
        public Nullable<int> AdminTabId { get; set; }
        public string HomeDirectory { get; set; }
        public Nullable<int> SplashTabId { get; set; }
        public int PageQuota { get; set; }
        public int UserQuota { get; set; }
    
        public virtual ICollection<DNN_AnonymousUsers> DNN_AnonymousUsers { get; set; }
        public virtual ICollection<DNN_Files> DNN_Files { get; set; }
        public virtual ICollection<DNN_Folders> DNN_Folders { get; set; }
        public virtual ICollection<DNN_Modules> DNN_Modules { get; set; }
        public virtual ICollection<DNN_PortalAlias> DNN_PortalAlias { get; set; }
        public virtual ICollection<DNN_PortalDesktopModules> DNN_PortalDesktopModules { get; set; }
        public virtual ICollection<DNN_Profile> DNN_Profile { get; set; }
        public virtual ICollection<DNN_ProfilePropertyDefinition> DNN_ProfilePropertyDefinition { get; set; }
        public virtual ICollection<DNN_RoleGroups> DNN_RoleGroups { get; set; }
        public virtual ICollection<DNN_Roles> DNN_Roles { get; set; }
        public virtual ICollection<DNN_SiteLog> DNN_SiteLog { get; set; }
        public virtual ICollection<DNN_Skins> DNN_Skins { get; set; }
        public virtual ICollection<DNN_SystemMessages> DNN_SystemMessages { get; set; }
        public virtual ICollection<DNN_Tabs> DNN_Tabs { get; set; }
        public virtual ICollection<DNN_Urls> DNN_Urls { get; set; }
        public virtual ICollection<DNN_UrlTracking> DNN_UrlTracking { get; set; }
        public virtual ICollection<DNN_UserPortals> DNN_UserPortals { get; set; }
        public virtual ICollection<DNN_UsersOnline> DNN_UsersOnline { get; set; }
        public virtual ICollection<DNN_Vendors> DNN_Vendors { get; set; }
    }
}
