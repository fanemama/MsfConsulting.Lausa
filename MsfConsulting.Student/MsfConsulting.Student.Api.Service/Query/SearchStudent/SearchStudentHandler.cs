﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MsfConsulting.Student.Api.Service.Query
{
    class SearchStudentQueryHandler : IRequestHandler<SearchStudentQuery, IEnumerable<Dto.Student>>
    {

        //private readonly QueriesConnectionString _connectionString;

        //public GetListQueryHandler(QueriesConnectionString connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        public async Task<IEnumerable<Dto.Student>> Handle(SearchStudentQuery request, CancellationToken cancellationToken)
        {
            //string sql = @"
            //        SELECT s.StudentID Id, s.Name, s.Email,
	           //         s.FirstCourseName Course1, s.FirstCourseCredits Course1Credits, s.FirstCourseGrade Course1Grade,
	           //         s.SecondCourseName Course2, s.SecondCourseCredits Course2Credits, s.SecondCourseGrade Course2Grade
            //        FROM dbo.Student s
            //        WHERE (s.FirstCourseName = @Course
		          //          OR s.SecondCourseName = @Course
		          //          OR @Course IS NULL)
            //            AND (s.NumberOfEnrollments = @Number
            //                OR @Number IS NULL)
            //        ORDER BY s.StudentID ASC";

            //using (SqlConnection connection = new SqlConnection(_connectionString.Value))
            //{
            //    List<StudentDto> students = connection
            //        .Query<StudentDto>(sql, new
            //        {
            //            Course = query.EnrolledIn,
            //            Number = query.NumberOfCourses
            //        })
            //        .ToList();

            //    return students;

                return await Task.FromResult(new List<Dto.Student>());
            }
    }
}
