﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using TryCatchFail.CodeStock2011.FailTracker.Core.Domain;

namespace TryCatchFail.CodeStock2011.FailTracker.Web.Models.Issues
{
	public class ViewIssueViewModel
	{
		[UIHint("Title")]
		public string Title { get; set; }

		[DataType(DataType.EmailAddress)]
		[DisplayName("Assigned To")]
		public string AssignedTo { get; set; }

		[DataType(DataType.MultilineText)]
		public string Body { get; set; }

		public PointSize Size { get; set; }

		public IssueType Type { get; set; }
	}
}