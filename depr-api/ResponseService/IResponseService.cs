﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.types;


namespace vdivsvirus.ResponseService
{
    /**
     * Response-Service
     * ... UI Service (Client)
     * ... Response Service (Server)
     */
    public interface IResponseService
    {
        /**
        * NewFindingAvailable 
        * ... request the availability of new to finding
        */
        bool NewFindingAvailable();

        /**
        * RequestNextDataSet 
        * ... request the next data set
        */
        UserResponseDataSet RequestFinding(Guid userId);

        /**
        * SendDataResultSet 
        * ... send propability data back after finished analysis.
        */
        UserHistoryDataSet RequestFindingHistory(Guid userId);
    }
}
