﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RizSoft.MtbSchool.Domain.Models;

public partial class Tour
{
    public int Id { get; set; }

    public DateTime TourDate { get; set; }

    public string TourTitle { get; set; }

    public bool? IsOnline { get; set; }

    public string IdActivityType { get; set; }

    public string KomootId { get; set; }

    public string GarminId { get; set; }

    public string StravaId { get; set; }

    public string OutdooractiveId { get; set; }

    public int? TourFinderId { get; set; }

    public string ReliveId { get; set; }

    public string TrailforksId { get; set; }

    public string YoutubeId { get; set; }

    public int? PhotoGalleryId { get; set; }

    public bool? HasCover { get; set; }

    public bool? HasGallery { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? TotalTime { get; set; }

    public TimeOnly? MovingTime { get; set; }

    public TimeOnly? ElapsedTime { get; set; }

    public decimal? Distance { get; set; }

    public int? AvgHr { get; set; }

    public int? MaxHr { get; set; }

    public decimal? AvgSpeed { get; set; }

    public decimal? MaxSpeed { get; set; }

    public int? TotalAscent { get; set; }

    public int? TotalDescent { get; set; }

    public int? AvgCadence { get; set; }

    public int? MaxCadence { get; set; }

    public decimal? Grit { get; set; }

    public decimal? Flow { get; set; }

    public int? MinElevation { get; set; }

    public int? MaxElevation { get; set; }

    public decimal? MinTemperature { get; set; }

    public decimal? MaxTemperature { get; set; }

    public decimal? AvgTemperature { get; set; }

    public short? LandscapeRating { get; set; }

    public short? TechnicRating { get; set; }

    public bool? TourDone { get; set; }

    public bool? TourPlanned { get; set; }

    public string Source { get; set; }

    public string Tags { get; set; }

    public string ExternalUrl { get; set; }

    public string Comment { get; set; }

    public bool? HasAlbum { get; set; }

    public string Slug { get; set; }

    public string GpxFile { get; set; }

    public virtual PhotoGallery PhotoGallery { get; set; }

    public virtual ICollection<TourParticipant> TourParticipants { get; set; } = new List<TourParticipant>();
}