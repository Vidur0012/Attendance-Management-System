﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServices.AttendanceService
{
    [ServiceContract]
    public interface IAttendanceService
    {
        [OperationContract]
        string AddAttendances(List<int> sids, List<bool> presents, int tid, DateTime dt, int cls, string sub);
        [OperationContract]

        IEnumerable<Attendance> GetAllAttendanceByTeacher(int tid);
        [OperationContract]
        IEnumerable<Attendance> GetAllAttendanceByDate(DateTime dt);

    }
}