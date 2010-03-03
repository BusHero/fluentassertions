﻿using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentAssertions
{
    public static partial class CustomAssertionExtensions
    {
        #region Nested type: DateTimeAssertions

        [DebuggerNonUserCode]
        public class DateTimeAssertions : Assertions<DateTime?, DateTimeAssertions>
        {
            protected DateTimeAssertions(DateTime? value)
            {
                ActualValue = value;
            }

            internal DateTimeAssertions(DateTime value)
            {
                ActualValue = value;
            }

            public AndConstraint<DateTimeAssertions> Equal(DateTime expected)
            {
                return Equal(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> Equal(DateTime expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value == expected),
                           "Expected <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> BeBefore(DateTime expected)
            {
                return BeBefore(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> BeBefore(DateTime expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.CompareTo(expected) < 0),
                           "Expected a date/time before <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> BeOnOrBefore(DateTime expected)
            {
                return BeOnOrBefore(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> BeOnOrBefore(DateTime expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.CompareTo(expected) <= 0),
                           "Expected a date/time on or before <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> BeAfter(DateTime expected)
            {
                return BeAfter(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> BeAfter(DateTime expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.CompareTo(expected) > 0),
                           "Expected a date/time after <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> BeOnOrAfter(DateTime expected)
            {
                return BeOnOrAfter(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> BeOnOrAfter(DateTime expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.CompareTo(expected) >= 0),
                           "Expected a date/time on or after <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> HaveYear(int expected)
            {
                return HaveYear(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> HaveYear(int expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.Year == expected),
                           "Expected year <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value.Year, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> HaveMonth(int expected)
            {
                return HaveMonth(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> HaveMonth(int expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.Month == expected),
                           "Expected month <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value.Month, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> HaveDay(int expected)
            {
                return HaveDay(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> HaveDay(int expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.Day == expected),
                           "Expected day <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value.Day, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> HaveHour(int expected)
            {
                return HaveHour(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> HaveHour(int expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.Hour == expected),
                           "Expected hour <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value.Hour, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> HaveMinute(int expected)
            {
                return HaveMinute(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> HaveMinute(int expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.Minute == expected),
                           "Expected minute <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value.Minute, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> HaveSecond(int expected)
            {
                return HaveSecond(expected, string.Empty);
            }

            public AndConstraint<DateTimeAssertions> HaveSecond(int expected, string reason, params object[] reasonParameters)
            {
                AssertThat(() => (ActualValue.Value.Second == expected),
                           "Expected second <{0}>{2}, but found <{1}>.",
                           expected, ActualValue.Value.Second, reason, reasonParameters);

                return new AndConstraint<DateTimeAssertions>(this);
            }
        }

        #endregion

        #region Nested type: NullableDateTimeAssertions

        [DebuggerNonUserCode]
        public class NullableDateTimeAssertions : DateTimeAssertions
        {
            internal NullableDateTimeAssertions(DateTime? expected)
                : base(expected)
            {
            }

            public AndConstraint<NullableDateTimeAssertions> HaveValue()
            {
                return HaveValue("Expected variable to have a value. Actual: null");
            }

            public AndConstraint<NullableDateTimeAssertions> HaveValue(string reason, params object[] reasonParameters)
            {
                AssertThat(ActualValue.HasValue, "Expected variable to have a value. Actual: null", null, ActualValue, reason, reasonParameters);
                return new AndConstraint<NullableDateTimeAssertions>(this);
            }

            public AndConstraint<NullableDateTimeAssertions> NotHaveValue()
            {
                return NotHaveValue("Did not expect variable to have a value. Actual: {0}", ActualValue);
            }

            public AndConstraint<NullableDateTimeAssertions> NotHaveValue(string reason, params object[] reasonParameters)
            {
                AssertThat(!ActualValue.HasValue, "Did not expect variable to have a value, but found {1}", null, ActualValue, reason, reasonParameters);
                return new AndConstraint<NullableDateTimeAssertions>(this);
            }

            public AndConstraint<DateTimeAssertions> Equal(DateTime? expected)
            {
                return Equal(expected, "Expected expected {0}. Actual: {1}", expected, ActualValue);
            }

            public AndConstraint<DateTimeAssertions> Equal(DateTime? expected, string reason, params object[] reasonParameters)
            {
                AssertThat(ActualValue == expected, "Expected {0}, but found {1}{2}", expected, ActualValue, reason, reasonParameters);
                return new AndConstraint<DateTimeAssertions>(this);
            }
        }

        #endregion
    }
}