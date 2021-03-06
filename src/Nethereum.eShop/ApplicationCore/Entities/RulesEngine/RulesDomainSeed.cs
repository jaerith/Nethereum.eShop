﻿using System;
using System.Collections.Generic;

using Microsoft.Data.SqlClient;

namespace Nethereum.eShop.ApplicationCore.Entities.RulesEngine
{
    public class RulesDomainSeed : BaseEntity
    {
        public RulesDomainSeed()
        {
            Init();
        }

        public RulesDomainSeed(SqlConnection conn, string table, HashSet<string> cols)
        {
            Init();

            Connection  = conn;
            TargetTable = table;
            Columns     = cols;
        }

        public RulesDomainSeed(HashSet<Type> types)
        {
            Init();

            ClassTypes = types;
        }

        #region Properties 

        public SqlConnection Connection { get; protected set; }

        public string TargetTable { get; protected set; }

        public HashSet<string> Columns { get; protected set; }

        public HashSet<Type> ClassTypes { get; protected set; }

        #endregion

        #region Support Methods

        private void Init()
        {
            Connection  = null;
            TargetTable = null;
            Columns     = null;
            ClassTypes  = null;
        }

        #endregion
    }
}
