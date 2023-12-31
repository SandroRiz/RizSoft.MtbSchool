﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RizSoft.MtbSchool.Domain.Models;

public partial class Page
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Abstract { get; set; }

    public string PageContent { get; set; }

    public string Keywords { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public bool? IsPublished { get; set; }

    public bool? IsFrontPage { get; set; }

    public int? Parent { get; set; }

    public bool? ShowInList { get; set; }

    public string Slug { get; set; }

    public bool IsDeleted { get; set; }

    public int? PhotoGalleryId { get; set; }

    public int SortOrder { get; set; }

    public virtual PhotoGallery PhotoGallery { get; set; }
}