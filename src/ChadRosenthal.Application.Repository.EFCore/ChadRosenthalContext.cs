﻿using ChadRosenthal.Application.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChadRosenthal.Application.Repository.EFCore
{
    public class ChadRosenthalContext : IdentityDbContext<CardholderUser>
    {
        public ChadRosenthalContext(DbContextOptions<ChadRosenthalContext> options) : base(options)
        {

        }
        public DbSet<NewsArticle> NewsArticles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<NewsArticle>().HasData(new NewsArticle(1, "This is the first article", "Chad Rosenthal", new DateTime(2018, 9, 1), "first-article", "Dolor swine nostrud voluptate jowl tri-tip turducken kevin. Officia turkey alcatra, bacon magna consectetur deserunt tri-tip exercitation eu doner anim aliquip cow.", "<p>Bacon ipsum dolor amet minim pork loin capicola officia shoulder aliquip. Frankfurter beef brisket aute minim, meatball officia adipisicing anim commodo reprehenderit ham hock. Turkey salami meatloaf, short loin exercitation velit shank ad biltong laborum. Meatball ut flank pork belly eiusmod qui ipsum salami. Lorem irure meatball cupim ground round turkey corned beef beef ribs ut magna et duis doner tri-tip turducken. Swine incididunt venison cupidatat bacon. Excepteur beef ribs short ribs in, culpa swine fugiat nulla.</p><p>Ad anim ut sausage. Ball tip ut shank boudin meatloaf consectetur meatball aliquip ham duis mollit kevin cupidatat adipisicing kielbasa. Officia pastrami ex est pariatur. Short ribs consequat consectetur beef. Turducken adipisicing proident eiusmod boudin elit in rump qui jowl occaecat aute. Cillum ground round id flank minim, aliquip picanha. Ut spare ribs incididunt lorem turkey tongue meatball ribeye dolore ex in commodo meatloaf tri-tip pork.</p><p>Brisket commodo ad, picanha nulla in pig consequat hamburger meatloaf shankle alcatra veniam. Irure exercitation voluptate buffalo biltong et. Ribeye magna cupidatat, meatloaf aliqua ut exercitation sunt bresaola consectetur minim shank. Short ribs pancetta fatback ham, jowl corned beef frankfurter exercitation adipisicing voluptate pork chop buffalo aute cillum.</p><p>Pig dolore pastrami, biltong qui tail anim. T-bone pork belly hamburger, shoulder pancetta anim porchetta pig. Sausage nostrud burgdoggen shank tenderloin adipisicing. Id laborum nostrud jowl, meatloaf biltong proident enim andouille pancetta. Labore pork belly culpa, et velit sunt ribeye id qui elit pig occaecat. Sausage meatloaf ball tip sunt short ribs esse cow excepteur frankfurter cupidatat aliquip ea. Beef pastrami cow tri-tip prosciutto, filet mignon ex ut turducken short loin meatloaf kielbasa fatback.</p><p>Boudin ut hamburger proident biltong laboris shankle. Eiusmod quis ex incididunt, ullamco filet mignon pork chop shankle dolore culpa laborum esse. Boudin ipsum non occaecat lorem officia. Ullamco boudin short ribs alcatra frankfurter cillum filet mignon biltong bacon. Exercitation prosciutto cow, ad shoulder laboris drumstick salami flank ullamco pancetta in nulla. Turkey ipsum pastrami, bresaola salami jowl consequat magna tongue shank ham hock cupidatat.</p>"));
            modelBuilder.Entity<NewsArticle>().HasData(new NewsArticle(2, "Second article is the best", "Chad Rosenthal", new DateTime(2018, 10, 11), "second-article", "Corned beef leberkas pancetta, fatback id et excepteur do pariatur ut nulla est. Pariatur shank mollit, aute ad ground round brisket sint pig occaecat bacon tri-tip.", "<p>Bacon ipsum dolor amet minim pork loin capicola officia shoulder aliquip. Frankfurter beef brisket aute minim, meatball officia adipisicing anim commodo reprehenderit ham hock. Turkey salami meatloaf, short loin exercitation velit shank ad biltong laborum. Meatball ut flank pork belly eiusmod qui ipsum salami. Lorem irure meatball cupim ground round turkey corned beef beef ribs ut magna et duis doner tri-tip turducken. Swine incididunt venison cupidatat bacon. Excepteur beef ribs short ribs in, culpa swine fugiat nulla.</p><p>Ad anim ut sausage. Ball tip ut shank boudin meatloaf consectetur meatball aliquip ham duis mollit kevin cupidatat adipisicing kielbasa. Officia pastrami ex est pariatur. Short ribs consequat consectetur beef. Turducken adipisicing proident eiusmod boudin elit in rump qui jowl occaecat aute. Cillum ground round id flank minim, aliquip picanha. Ut spare ribs incididunt lorem turkey tongue meatball ribeye dolore ex in commodo meatloaf tri-tip pork.</p><p>Brisket commodo ad, picanha nulla in pig consequat hamburger meatloaf shankle alcatra veniam. Irure exercitation voluptate buffalo biltong et. Ribeye magna cupidatat, meatloaf aliqua ut exercitation sunt bresaola consectetur minim shank. Short ribs pancetta fatback ham, jowl corned beef frankfurter exercitation adipisicing voluptate pork chop buffalo aute cillum.</p><p>Pig dolore pastrami, biltong qui tail anim. T-bone pork belly hamburger, shoulder pancetta anim porchetta pig. Sausage nostrud burgdoggen shank tenderloin adipisicing. Id laborum nostrud jowl, meatloaf biltong proident enim andouille pancetta. Labore pork belly culpa, et velit sunt ribeye id qui elit pig occaecat. Sausage meatloaf ball tip sunt short ribs esse cow excepteur frankfurter cupidatat aliquip ea. Beef pastrami cow tri-tip prosciutto, filet mignon ex ut turducken short loin meatloaf kielbasa fatback.</p><p>Boudin ut hamburger proident biltong laboris shankle. Eiusmod quis ex incididunt, ullamco filet mignon pork chop shankle dolore culpa laborum esse. Boudin ipsum non occaecat lorem officia. Ullamco boudin short ribs alcatra frankfurter cillum filet mignon biltong bacon. Exercitation prosciutto cow, ad shoulder laboris drumstick salami flank ullamco pancetta in nulla. Turkey ipsum pastrami, bresaola salami jowl consequat magna tongue shank ham hock cupidatat.</p>"));
            modelBuilder.Entity<NewsArticle>().HasData(new NewsArticle(3, "Third article is the best", "Chad Rosenthal", new DateTime(2018, 11, 22), "third-article", "Magna pariatur reprehenderit consectetur nostrud, quis filet mignon biltong in mollit turkey frankfurter beef ribs dolore.", "<p>Bacon ipsum dolor amet minim pork loin capicola officia shoulder aliquip. Frankfurter beef brisket aute minim, meatball officia adipisicing anim commodo reprehenderit ham hock. Turkey salami meatloaf, short loin exercitation velit shank ad biltong laborum. Meatball ut flank pork belly eiusmod qui ipsum salami. Lorem irure meatball cupim ground round turkey corned beef beef ribs ut magna et duis doner tri-tip turducken. Swine incididunt venison cupidatat bacon. Excepteur beef ribs short ribs in, culpa swine fugiat nulla.</p><p>Ad anim ut sausage. Ball tip ut shank boudin meatloaf consectetur meatball aliquip ham duis mollit kevin cupidatat adipisicing kielbasa. Officia pastrami ex est pariatur. Short ribs consequat consectetur beef. Turducken adipisicing proident eiusmod boudin elit in rump qui jowl occaecat aute. Cillum ground round id flank minim, aliquip picanha. Ut spare ribs incididunt lorem turkey tongue meatball ribeye dolore ex in commodo meatloaf tri-tip pork.</p><p>Brisket commodo ad, picanha nulla in pig consequat hamburger meatloaf shankle alcatra veniam. Irure exercitation voluptate buffalo biltong et. Ribeye magna cupidatat, meatloaf aliqua ut exercitation sunt bresaola consectetur minim shank. Short ribs pancetta fatback ham, jowl corned beef frankfurter exercitation adipisicing voluptate pork chop buffalo aute cillum.</p><p>Pig dolore pastrami, biltong qui tail anim. T-bone pork belly hamburger, shoulder pancetta anim porchetta pig. Sausage nostrud burgdoggen shank tenderloin adipisicing. Id laborum nostrud jowl, meatloaf biltong proident enim andouille pancetta. Labore pork belly culpa, et velit sunt ribeye id qui elit pig occaecat. Sausage meatloaf ball tip sunt short ribs esse cow excepteur frankfurter cupidatat aliquip ea. Beef pastrami cow tri-tip prosciutto, filet mignon ex ut turducken short loin meatloaf kielbasa fatback.</p><p>Boudin ut hamburger proident biltong laboris shankle. Eiusmod quis ex incididunt, ullamco filet mignon pork chop shankle dolore culpa laborum esse. Boudin ipsum non occaecat lorem officia. Ullamco boudin short ribs alcatra frankfurter cillum filet mignon biltong bacon. Exercitation prosciutto cow, ad shoulder laboris drumstick salami flank ullamco pancetta in nulla. Turkey ipsum pastrami, bresaola salami jowl consequat magna tongue shank ham hock cupidatat.</p>"));
            modelBuilder.Entity<NewsArticle>().HasData(new NewsArticle(4, "Fourth article is a sad meaty article", "Chad Rosenthal", new DateTime(2018, 12, 31), "fourth-article", "Picanha in cillum shankle, shoulder pork loin tenderloin beef ut enim chuck est pancetta. Sirloin turducken nostrud ribeye laborum tri-tip, ut aute adipisicing non ea.", "<p>Bacon ipsum dolor amet minim pork loin capicola officia shoulder aliquip. Frankfurter beef brisket aute minim, meatball officia adipisicing anim commodo reprehenderit ham hock. Turkey salami meatloaf, short loin exercitation velit shank ad biltong laborum. Meatball ut flank pork belly eiusmod qui ipsum salami. Lorem irure meatball cupim ground round turkey corned beef beef ribs ut magna et duis doner tri-tip turducken. Swine incididunt venison cupidatat bacon. Excepteur beef ribs short ribs in, culpa swine fugiat nulla.</p><p>Ad anim ut sausage. Ball tip ut shank boudin meatloaf consectetur meatball aliquip ham duis mollit kevin cupidatat adipisicing kielbasa. Officia pastrami ex est pariatur. Short ribs consequat consectetur beef. Turducken adipisicing proident eiusmod boudin elit in rump qui jowl occaecat aute. Cillum ground round id flank minim, aliquip picanha. Ut spare ribs incididunt lorem turkey tongue meatball ribeye dolore ex in commodo meatloaf tri-tip pork.</p><p>Brisket commodo ad, picanha nulla in pig consequat hamburger meatloaf shankle alcatra veniam. Irure exercitation voluptate buffalo biltong et. Ribeye magna cupidatat, meatloaf aliqua ut exercitation sunt bresaola consectetur minim shank. Short ribs pancetta fatback ham, jowl corned beef frankfurter exercitation adipisicing voluptate pork chop buffalo aute cillum.</p><p>Pig dolore pastrami, biltong qui tail anim. T-bone pork belly hamburger, shoulder pancetta anim porchetta pig. Sausage nostrud burgdoggen shank tenderloin adipisicing. Id laborum nostrud jowl, meatloaf biltong proident enim andouille pancetta. Labore pork belly culpa, et velit sunt ribeye id qui elit pig occaecat. Sausage meatloaf ball tip sunt short ribs esse cow excepteur frankfurter cupidatat aliquip ea. Beef pastrami cow tri-tip prosciutto, filet mignon ex ut turducken short loin meatloaf kielbasa fatback.</p><p>Boudin ut hamburger proident biltong laboris shankle. Eiusmod quis ex incididunt, ullamco filet mignon pork chop shankle dolore culpa laborum esse. Boudin ipsum non occaecat lorem officia. Ullamco boudin short ribs alcatra frankfurter cillum filet mignon biltong bacon. Exercitation prosciutto cow, ad shoulder laboris drumstick salami flank ullamco pancetta in nulla. Turkey ipsum pastrami, bresaola salami jowl consequat magna tongue shank ham hock cupidatat.</p>"));
        }
    }
}
