﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Subtext.Framework.Components;

namespace Subtext.Framework.Routing
{
    public class AdminUrlHelper
    {
        public AdminUrlHelper(UrlHelper urlHelper) {
            Url = urlHelper;
        }

        protected UrlHelper Url {
            get;
            private set;
        }

        public VirtualPath Home() {
            return Url.AdminUrl("Default.aspx");
        }

        public VirtualPath Rss()
        {
            return Url.AdminUrl("AdminRss.axd");
        }

        public VirtualPath ImportExport() {
            return Url.AdminUrl("ImportExport.aspx");
        }

        public VirtualPath PostsList() {
            return Url.AdminUrl("Posts");
        }

        public VirtualPath PostsEdit()
        {
            return Url.AdminUrl("Posts/Edit.aspx");
        }

        public VirtualPath PostsEdit(int id)
        {
            return Url.AdminUrl("Posts/Edit.aspx", new {PostId = id });
        }

        public VirtualPath ArticlesList()
        {
            return Url.AdminUrl("Articles");
        }

        public VirtualPath ArticlesEdit()
        {
            return Url.AdminUrl("Articles/Edit.aspx");
        }

        public VirtualPath FeedbackList()
        {
            return Url.AdminUrl("Feedback");
        }

        public VirtualPath FeedbackEdit()
        {
            return Url.AdminUrl("Feedback/Edit.aspx");
        }

        public VirtualPath LinksEdit()
        {
            return Url.AdminUrl("EditLinks.aspx");
        }

        public VirtualPath GalleriesEdit()
        {
            return Url.AdminUrl("EditGalleries.aspx");
        }

        public VirtualPath Referrers(int id)
        {
            return Url.AdminUrl("Referrers.aspx");
        }

        public VirtualPath Statistics()
        {
            return Url.AdminUrl("Statistics.aspx");
        }

        public VirtualPath Options()
        {
            return Url.AdminUrl("Options.aspx");
        }

        public VirtualPath Credits()
        {
            return Url.AdminUrl("Credits.aspx");
        }

        public VirtualPath EditCategories(CategoryType categoryType) {
            return Url.AdminUrl("EditCategories.aspx", new {catType = categoryType });
        }

        public VirtualPath ErrorLog() {
            return Url.AdminUrl("ErrorLog.aspx");
        }
    }
}