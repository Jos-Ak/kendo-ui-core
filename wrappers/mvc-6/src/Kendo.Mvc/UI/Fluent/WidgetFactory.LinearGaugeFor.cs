﻿using System;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        public virtual LinearGaugeBuilder LinearGaugeFor<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            var metadata = GetModelMetadata(expression);

            var widget = LinearGauge()
                         .Expression(GetExpressionName(expression))
                         .Pointer(pointer => pointer.Value(
                            Convert.ToDouble(metadata.Model)
                         ));

            return widget;
        }

        public virtual LinearGaugeBuilder LinearGaugeFor<TValue>(Expression<Func<TModel, Nullable<TValue>>> expression)
                    where TValue : struct, IComparable
        {
            var metadata = GetModelMetadata(expression);

            var widget = LinearGauge()
                         .Expression(GetExpressionName(expression))
                         .Pointer(pointer => pointer.Value(
                            Convert.ToDouble(metadata.Model)
                         ));

            return widget;
        }
    }
}