﻿using FluentValidation;
using OnTask.Business.Models.Event;
using OnTask.Common;

namespace OnTask.Business.Validators.Event
{
    /// <summary>
    /// Provides validation for an <see cref="EventTypeModel"/> class.
    /// </summary>
    public class EventTypeModelValidator : AbstractValidator<EventTypeModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventTypeModelValidator"/> class.
        /// </summary>
        public EventTypeModelValidator()
        {
            RuleSet(Constants.RuleSetNameForInsert, () =>
            {
                ExecuteCommonRules();
            });
            RuleSet(Constants.RuleSetNameForUpdate, () =>
            {
                RuleFor(x => x.Id).NotNull().WithMessage("An event type must be specified.");
                ExecuteCommonRules();
            });
        }

        private void ExecuteCommonRules()
        {
            RuleFor(x => x.EventGroupId).NotNull().WithMessage("An event group is required.");
            RuleFor(x => x.Name)
                .NotNull().WithMessage("A name is required")
                .NotEmpty().WithMessage("A name is required");
        }
    }
}
