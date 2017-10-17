﻿using NUnit.Framework;
using NumberConverter;

namespace NumberConverter.Test
{
    [TestFixture]
    public class NumberConverter
    {
        private NumberConverter subject;

        [SetUp]
        public void Setup()
        {
            subject = new NumberConverter();
        }

        [Test]
        public void Zero()
        {
            Assert.That(subject.ToWords(0), Is.EqualTo("zero"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Single_Digit()
        {
            Assert.That(subject.ToWords(1), Is.EqualTo("one"));
            Assert.That(subject.ToWords(9), Is.EqualTo("nine"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Special_Case_Two_Digit()
        {
            Assert.That(subject.ToWords(10), Is.EqualTo("ten"));
            Assert.That(subject.ToWords(19), Is.EqualTo("nineteen"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Multiples_Of_Ten()
        {
            Assert.That(subject.ToWords(20), Is.EqualTo("twenty"));
            Assert.That(subject.ToWords(90), Is.EqualTo("ninety"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Not_Multiples_Of_Ten_21_To_99()
        {
            Assert.That(subject.ToWords(21), Is.EqualTo("twenty-one"));
            Assert.That(subject.ToWords(55), Is.EqualTo("fifty-five"));
            Assert.That(subject.ToWords(99), Is.EqualTo("ninety-nine"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Hundreds()
        {
            Assert.That(subject.ToWords(100), Is.EqualTo("one hundred"));
            Assert.That(subject.ToWords(900), Is.EqualTo("nine hundred"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Not_Multiples_Of_One_Hundred_Less_Than_1000()
        {
            Assert.That(subject.ToWords(101), Is.EqualTo("one hundred one"));
            Assert.That(subject.ToWords(999), Is.EqualTo("nine hundred ninety-nine"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Thousands()
        {
            Assert.That(subject.ToWords(1000), Is.EqualTo("one thousand"));
            Assert.That(subject.ToWords(9000), Is.EqualTo("nine thousand"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Not_Even_Thousands()
        {
            Assert.That(subject.ToWords(9999), Is.EqualTo("nine thousand nine hundred ninety-nine"));
            Assert.That(subject.ToWords(9911), Is.EqualTo("nine thousand nine hundred eleven"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Tens_Of_Thousands()
        {
            Assert.That(subject.ToWords(10000), Is.EqualTo("ten thousand"));
            Assert.That(subject.ToWords(19000), Is.EqualTo("nineteen thousand"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Tens_Of_Thousands_And_Some()
        {
            Assert.That(subject.ToWords(19999), Is.EqualTo("nineteen thousand nine hundred ninety-nine"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Hundred_Thousand()
        {
            Assert.That(subject.ToWords(100000), Is.EqualTo("one hundred thousand"));
            Assert.That(subject.ToWords(700000), Is.EqualTo("seven hundred thousand"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Not_Exactly_Hundred_Thousand()
        {
            Assert.That(subject.ToWords(198000), Is.EqualTo("one hundred ninety-eight thousand"));
            Assert.That(subject.ToWords(701020), Is.EqualTo("seven hundred one thousand twenty"));
        }

        [Ignore("Ignore a test.")]
        [Test]
        public void Millions()
        {
            Assert.That(subject.ToWords(1000000), Is.EqualTo("one million"));
        }
    }
}
