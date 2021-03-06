﻿using ExRam.Gremlinq.Core.Serialization;

namespace ExRam.Gremlinq.Core
{
    public sealed class LabelStep : Step
    {
        public static readonly LabelStep Instance = new LabelStep();

        private LabelStep()
        {
        }

        public override void Accept(IGremlinQueryElementVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
