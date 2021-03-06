﻿using ExRam.Gremlinq.Core.Serialization;

namespace ExRam.Gremlinq.Core
{
    public sealed class AggregateStep : Step
    {
        public AggregateStep(StepLabel stepLabel)
        {
            StepLabel = stepLabel;
        }

        public override void Accept(IGremlinQueryElementVisitor visitor)
        {
            visitor.Visit(this);
        }

        public StepLabel StepLabel { get; }
    }
}
