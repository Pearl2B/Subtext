<%@ Control Language="c#" AutoEventWireup="false" Inherits="Subtext.Web.UI.Controls.Comments" %>
<a name="feedback" title="feedback anchor"></a>
<div id="comments">
<h3>Feedback</h3>
	<asp:Literal ID = "NoCommentMessage" Runat ="server" />
	<asp:Repeater id="CommentList" runat="server" OnItemCreated="CommentsCreated" OnItemCommand="RemoveComment_ItemCommand">
		<ItemTemplate>
		    <hr style="visibility:hidden; clear:both;" />
		    <asp:Image runat="server" id="GravatarImg" visible="False" CssClass="avatar" PlaceHolderImage="~/images/shadow.gif" AlternateText="Gravatar" />
			<h4>
				<asp:Literal Runat = "server" ID = "Title" />
					<span>
						<asp:Literal id = "PostDate" Runat = "server" />
					</span>
				<asp:HyperLink Target="_blank" Runat="server" ID="NameLink" />
			</h4>
			<p>
				<asp:Literal id = "PostText" Runat = "server" />
				<asp:LinkButton Runat="server" ID="EditLink" CausesValidation="False" />
			</p>
		</ItemTemplate>

	</asp:Repeater>
</div>