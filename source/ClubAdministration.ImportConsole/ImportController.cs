using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClubAdministration.Core.Entities;
using Utils;

namespace ClubAdministration.ImportConsole
{
    public class ImportController
    {
        const string Filename = "members.csv";

        public static MemberSection[] ReadFromCsv()
        {
            string[][] matrix = MyFile.ReadStringMatrixFromCsv(Filename, false);
            List<Member> members = matrix
                .GroupBy(line => line[0] + "~" + line[1])
                .Select(grp => new Member { LastName = grp.Key.Split('~')[0], FirstName = grp.Key.Split('~')[1] })
                .ToList();
            List<Section> sections = matrix
                .GroupBy(line => line[2])
                .Select(grp => new Section { Name = grp.Key})
                .ToList();
            var memberSections = matrix.Select(line => new MemberSection
            {
                Member = members.Single(m=>m.LastName == line[0] && m.FirstName == line[1]),
                Section = sections.Single(s=>s.Name == line[2])
            }).ToArray();
            return memberSections;
        }

    }
}
