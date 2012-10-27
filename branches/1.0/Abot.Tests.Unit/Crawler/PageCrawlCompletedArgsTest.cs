﻿using Abot.Crawler;
using Abot.Poco;
using NUnit.Framework;
using System;

namespace Abot.Tests.Unit.Crawler
{
    [TestFixture]
    public class PageCrawlCompletedArgsTest
    {
        [Test]
        public void Constructor_ValidArg_SetsPublicProperty()
        {
            CrawledPage page = new CrawledPage(new Uri("http://aaa.com/"));
            PageCrawlCompletedArgs args = new PageCrawlCompletedArgs(page);

            Assert.AreSame(page, args.CrawledPage);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_NullArg()
        {
            new PageCrawlCompletedArgs(null);
        }
    }
}
