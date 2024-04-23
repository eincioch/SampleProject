﻿using AutoMapper;
using SampleProject.Application.Features.SampleModel.Commands.CreateSampleModel;
using SampleProject.Application.Features.SampleModel.Commands.UpdateSampleModel;
using SampleProject.Application.ViewModels;
using SampleProject.Domain.Models;

namespace SampleProject.Application;

public static class SampleModelMapper
{
    public static SampleModelViewModel ToViewModel(this SampleModel input)
    {
        var config = new MapperConfiguration(cfg => 
            cfg.CreateMap<SampleModel, SampleModelViewModel>());

        var mapper = new Mapper(config);

        return mapper.Map<SampleModelViewModel>(input);
    }

    public static IList<SampleModelViewModel> ToViewModel(this IList<SampleModel> input)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<SampleModel, SampleModelViewModel>());

        var mapper = new Mapper(config);

        return mapper.Map<IList<SampleModelViewModel>>(input);
    }

    public static SampleModel ToEntity(this CreateSampleModelCommand input)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<CreateSampleModelCommand, SampleModel>());

        var mapper = new Mapper(config);

        return mapper.Map<SampleModel>(input);
    }

    public static SampleModel ToEntity(this UpdateSampleModelCommand input)
    {
        var config = new MapperConfiguration(cfg =>
            cfg.CreateMap<UpdateSampleModelCommand, SampleModel>());

        var mapper = new Mapper(config);

        return mapper.Map<SampleModel>(input);
    }
}
