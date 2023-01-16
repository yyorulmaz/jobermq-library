﻿using JoberMQ.Library.Database.Base;
using JoberMQ.Library.DatabaseObjects.Models;
using System.Collections.Generic;

namespace JoberMQ.Library.DatabaseObjects.Dbos
{
    public class JobDbo : DboPropertyGuidBase, IDboBase
    {
        public OperationModel Operation { get; set; }
        public ProducerModel Producer { get; set; }
        public InfoModel Info { get; set; }
        public PublisherModel Publisher { get; set; }
        public TimingModel Timing { get; set; }
        public RoutingModel ResultRouting { get; set; }
        public StatusModel Status { get; set; }
        public int Version { get; set; }
        public List<JobDetailDbo> JobDetails { get; set; }

    }
}