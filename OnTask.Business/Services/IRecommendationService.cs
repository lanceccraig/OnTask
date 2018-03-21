﻿using System;
using System.Collections.Generic;
using OnTask.Business.Models.Event;

namespace OnTask.Business.Services.Interfaces
{
    /// <summary>
    /// Exposes recommendations for ideal event completion.
    /// </summary>
    public interface IRecommendationService : IBaseService
    {
        /// <summary>
        /// Gets all of the recommended starting point for relevant <see cref="EventModel"/> classes.
        /// </summary>
        /// <param name="end">The ending <see cref="DateTime"/> for the time period to recommend.</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of all <see cref="RecommendationModel"/> classes.</returns>
        IEnumerable<RecommendationModel> GetRecommendations(DateTime end);
    }
}