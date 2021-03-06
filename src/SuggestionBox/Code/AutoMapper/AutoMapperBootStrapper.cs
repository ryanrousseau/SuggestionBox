﻿using AutoMapper;
using SuggestionBox.Data;
using SuggestionBox.Models;

namespace SuggestionBox.Code.AutoMapper
{
	public class AutoMapperBootStrapper
	{
		public static void Initialize()
		{
			Mapper.CreateMap<Suggestion, SuggestionModel>()
				.ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body.Replace("\n", "<br/>")))
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => (SuggestionStatus) src.Status));
			Mapper.CreateMap<SuggestionModel, Suggestion>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => (int)src.Status));

			Mapper.CreateMap<Comment, CommentModel>()
				.ForMember(dest => dest.Body, opt => opt.MapFrom(src => src.Body.Replace("\n", "<br/>")))
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => (CommentStatus)src.Status));
			Mapper.CreateMap<CommentModel, Comment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => (int) src.Status));
		}
	}
}