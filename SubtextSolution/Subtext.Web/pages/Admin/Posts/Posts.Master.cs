﻿using System;
using System.Web.UI.WebControls;
using Subtext.Framework;
using Subtext.Web.Admin.WebUI;
using Subtext.Web.Properties;

namespace Subtext.Web.Admin.Posts {
    public partial class Posts : AdminMasterPage 
    {
        protected override void OnLoad(EventArgs e) 
        {
            BindLocalUI();
            base.OnLoad(e);
        }

        private void BindLocalUI() 
        {
            HyperLink newPostLink = new HyperLink();
            newPostLink.Text = Resources.Label_NewPost;
            newPostLink.NavigateUrl = AdminUrl.PostsEdit();
            AdminMasterPage.AddToActions(newPostLink);

            HyperLink lnkEditCategories = Utilities.CreateHyperLink(Resources.Label_EditCategories,
                AdminUrl.EditCategories(categoryLinks.CategoryType));
            AdminMasterPage.AddToActions(lnkEditCategories);

            LinkButton lkbRebuildTags = Utilities.CreateLinkButton(Resources.Label_RebuildAllTags);
            lkbRebuildTags.CausesValidation = false;
            lkbRebuildTags.Click += OnRebuildTagsClick;
            AdminMasterPage.AddToActions(lkbRebuildTags);
        }

        private static void OnRebuildTagsClick(object sender, EventArgs e) 
        {
            Entries.RebuildAllTags();
        }

        protected AdminPageTemplate AdminMasterPage 
        {
            get 
            {
                return this.Master as AdminPageTemplate;
            }
        }

    }
}