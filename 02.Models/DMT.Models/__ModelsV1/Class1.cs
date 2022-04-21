namespace DMT.Models
{
    class Sample
    {
        #region Role

        /// <summary>
        /// Gets or sets GroupId
        /// </summary>
        [Category("Role")]
        [Description("Gets or sets GroupId.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("GroupId")]
        public virtual int GroupId
        {
            get
            {
                return _GroupId;
            }
            set
            {
                if (_GroupId != value)
                {
                    _GroupId = value;
                    this.Raise(() => this.GroupId);
                }
            }
        }
        /// <summary>
        /// Gets or sets Role Name EN.
        /// </summary>
        [Category("Role")]
        [Description("Gets or sets Role Name EN.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("RoleNameEN")]
        public virtual string RoleNameEN
        {
            get
            {
                return _RoleNameEN;
            }
            set
            {
                if (_RoleNameEN != value)
                {
                    _RoleNameEN = value;
                    this.Raise(() => this.RoleNameEN);
                }
            }
        }
        /// <summary>
        /// Gets or sets Role Name TH
        /// </summary>
        [Category("Role")]
        [Description("Gets or sets Role Name TH.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("RoleNameTH")]
        public virtual string RoleNameTH
        {
            get
            {
                return _RoleNameTH;
            }
            set
            {
                if (_RoleNameTH != value)
                {
                    _RoleNameTH = value;
                    this.Raise(() => this.RoleNameTH);
                }
            }
        }

        #endregion

        #region User

        /// <summary>
        /// Gets or sets User Id
        /// </summary>
        [Category("User")]
        [Description("Gets or sets User Id.")]
        [ReadOnly(true)]
        [Indexed]
        [MaxLength(10)]
        [PropertyMapName("UserId")]
        public virtual string UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                if (_UserId != value)
                {
                    _UserId = value;
                    this.Raise(() => this.UserId);
                }
            }
        }
        /// <summary>
        /// Gets or sets User Full Name EN
        /// </summary>
        [Category("User")]
        [Description("Gets or sets User Full Name EN.")]
        [ReadOnly(true)]
        [MaxLength(150)]
        [PropertyMapName("FullNameEN")]
        public virtual string FullNameEN
        {
            get
            {
                return _FullNameEN;
            }
            set
            {
                if (_FullNameEN != value)
                {
                    _FullNameEN = value;
                    this.Raise(() => this.FullNameEN);
                }
            }
        }
        /// <summary>
        /// Gets or sets User Full Name TH
        /// </summary>
        [Category("User")]
        [Description("Gets or sets User Full Name TH.")]
        [ReadOnly(true)]
        [MaxLength(150)]
        [PropertyMapName("FullNameTH")]
        public virtual string FullNameTH
        {
            get
            {
                return _FullNameTH;
            }
            set
            {
                if (_FullNameTH != value)
                {
                    _FullNameTH = value;
                    this.Raise(() => this.FullNameTH);
                }
            }
        }

        #endregion

        #region TSB

        /// <summary>
        /// Gets or sets TSBId.
        /// </summary>
        [Category("TSB")]
        [Description("Gets or sets TSBId.")]
        [ReadOnly(true)]
        [NotNull]
        [Indexed]
        [MaxLength(10)]
        [PropertyMapName("TSBId")]
        public string TSBId
        {
            get
            {
                return _TSBId;
            }
            set
            {
                if (_TSBId != value)
                {
                    _TSBId = value;
                    this.Raise(() => this.TSBId);
                }
            }
        }
        /// <summary>
        /// Gets or sets TSB Name EN.
        /// </summary>
        [Category("TSB")]
        [Description("Gets or sets TSB Name EN.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("TSBNameEN")]
        public virtual string TSBNameEN
        {
            get
            {
                return _TSBNameEN;
            }
            set
            {
                if (_TSBNameEN != value)
                {
                    _TSBNameEN = value;
                    this.Raise(() => this.TSBNameEN);
                }
            }
        }
        /// <summary>
        /// Gets or sets TSB Name TH.
        /// </summary>
        [Category("TSB")]
        [Description("Gets or sets TSB Name TH.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("TSBNameTH")]
        public virtual string TSBNameTH
        {
            get
            {
                return _TSBNameTH;
            }
            set
            {
                if (_TSBNameTH != value)
                {
                    _TSBNameTH = value;
                    this.Raise(() => this.TSBNameTH);
                }
            }
        }

        #endregion

        #region PlazaGroup

        /// <summary>
        /// Gets or sets Plaza Group Id.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets Plaza Group Id.")]
        [ReadOnly(true)]
        [NotNull]
        [Indexed]
        [MaxLength(10)]
        [PropertyMapName("PlazaGroupId")]
        public string PlazaGroupId
        {
            get
            {
                return _PlazaGroupId;
            }
            set
            {
                if (_PlazaGroupId != value)
                {
                    _PlazaGroupId = value;
                    this.Raise(() => this.PlazaGroupId);
                }
            }
        }
        /// <summary>
        /// Gets or sets Plaza Group Name EN.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets Plaza Group Name EN.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("PlazaGroupNameEN")]
        public virtual string PlazaGroupNameEN
        {
            get
            {
                return _PlazaGroupNameEN;
            }
            set
            {
                if (_PlazaGroupNameEN != value)
                {
                    _PlazaGroupNameEN = value;
                    this.Raise(() => this.PlazaGroupNameEN);
                }
            }
        }
        /// <summary>
        /// Gets or sets Plaza Group Name TH.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets Plaza Group Name TH.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("PlazaGroupNameTH")]
        public virtual string PlazaGroupNameTH
        {
            get
            {
                return _PlazaGroupNameTH;
            }
            set
            {
                if (_PlazaGroupNameTH != value)
                {
                    _PlazaGroupNameTH = value;
                    this.Raise(() => this.PlazaGroupNameTH);
                }
            }
        }
        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [Category("Plaza Group")]
        [Description("Gets or sets Direction.")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("Direction")]
        public virtual string Direction
        {
            get
            {
                return _Direction;
            }
            set
            {
                if (_Direction != value)
                {
                    _Direction = value;
                    this.Raise(() => this.Direction);
                }
            }
        }

        #endregion

        #region Plaza

        /// <summary>
        /// Gets or sets Plaza Id.
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets Plaza Id.")]
        [ReadOnly(true)]
        [NotNull]
        [Indexed]
        [MaxLength(10)]
        [PropertyMapName("PlazaId")]
        public string PlazaId
        {
            get
            {
                return _PlazaId;
            }
            set
            {
                if (_PlazaId != value)
                {
                    _PlazaId = value;
                    this.Raise(() => this.PlazaId);
                }
            }
        }
        /// <summary>
        /// Gets or sets SCW Plaza Id
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets SCW Plaza Id")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("SCWPlazaId")]
        public virtual int SCWPlazaId
        {
            get
            {
                return _SCWPlazaId;
            }
            set
            {
                if (_SCWPlazaId != value)
                {
                    _SCWPlazaId = value;
                    this.Raise(() => this.SCWPlazaId);
                }
            }
        }
        /// <summary>
        /// Gets or sets Plaza Name EN
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets Plaza Name EN")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("PlazaNameEN")]
        public virtual string PlazaNameEN
        {
            get
            {
                return _PlazaNameEN;
            }
            set
            {
                if (_PlazaNameEN != value)
                {
                    _PlazaNameEN = value;
                    this.Raise(() => this.PlazaNameEN);
                }
            }
        }
        /// <summary>
        /// Gets or sets Plaza Name TH
        /// </summary>
        [Category("Plaza")]
        [Description("Gets or sets Plaza Name TH")]
        [ReadOnly(true)]
        [Ignore]
        [PropertyMapName("PlazaNameTH")]
        public virtual string PlazaNameTH
        {
            get
            {
                return _PlazaNameTH;
            }
            set
            {
                if (_PlazaNameTH != value)
                {
                    _PlazaNameTH = value;
                    this.Raise(() => this.PlazaNameTH);
                }
            }
        }

        #endregion
    }

    public class FKs
    {
        #region Role

        /// <summary>
        /// Gets or sets GroupId.
        /// </summary>
        [PropertyMapName("GroupId")]
        public override int GroupId
        {
            get { return base.GroupId; }
            set { base.GroupId = value; }
        }
        /// <summary>
        /// Gets or sets Role Name EN.
        /// </summary>
        [MaxLength(50)]
        [PropertyMapName("RoleNameEN")]
        public override string RoleNameEN
        {
            get { return base.RoleNameEN; }
            set { base.RoleNameEN = value; }
        }
        /// <summary>
        /// Gets or sets Role Name TH.
        /// </summary>
        [MaxLength(50)]
        [PropertyMapName("RoleNameTH")]
        public override string RoleNameTH
        {
            get { return base.RoleNameTH; }
            set { base.RoleNameTH = value; }
        }

        #endregion

        #region TSB

        /// <summary>
        /// Gets or sets TSB Name EN.
        /// </summary>
        [MaxLength(100)]
        [PropertyMapName("TSBNameEN")]
        public override string TSBNameEN
        {
            get { return base.TSBNameEN; }
            set { base.TSBNameEN = value; }
        }
        /// <summary>
        /// Gets or sets TSB Name TH.
        /// </summary>
        [MaxLength(100)]
        [PropertyMapName("TSBNameTH")]
        public override string TSBNameTH
        {
            get { return base.TSBNameTH; }
            set { base.TSBNameTH = value; }
        }

        #endregion

        #region PlazaGroup

        /// <summary>
        /// Gets or sets Plaza Group Name EN.
        /// </summary>
        [MaxLength(100)]
        [PropertyMapName("PlazaGroupNameEN")]
        public override string PlazaGroupNameEN
        {
            get { return base.PlazaGroupNameEN; }
            set { base.PlazaGroupNameEN = value; }
        }
        /// <summary>
        /// Gets or sets Plaza Group Name TH.
        /// </summary>
        [MaxLength(100)]
        [PropertyMapName("PlazaGroupNameTH")]
        public override string PlazaGroupNameTH
        {
            get { return base.PlazaGroupNameTH; }
            set { base.PlazaGroupNameTH = value; }
        }
        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [MaxLength(10)]
        [PropertyMapName("Direction")]
        public override string Direction
        {
            get { return base.Direction; }
            set { base.Direction = value; }
        }

        #endregion

        #region Plaza

        /// <summary>
        /// Gets or sets SCW Plaza Id.
        /// </summary>
        [PropertyMapName("SCWPlazaId")]
        public override int SCWPlazaId
        {
            get { return base.SCWPlazaId; }
            set { base.SCWPlazaId = value; }
        }
        /// <summary>
        /// Gets or sets Plaza Name EN.
        /// </summary>
        [MaxLength(100)]
        [PropertyMapName("PlazaNameEN")]
        public override string PlazaNameEN
        {
            get { return base.PlazaNameEN; }
            set { base.PlazaNameEN = value; }
        }
        /// <summary>
        /// Gets or sets Plaza Name TH.
        /// </summary>
        [MaxLength(100)]
        [PropertyMapName("PlazaNameTH")]
        public override string PlazaNameTH
        {
            get { return base.PlazaNameTH; }
            set { base.PlazaNameTH = value; }
        }

        #endregion

        #region Shift

        /// <summary>
        /// Gets or sets Shift Name EN.
        /// </summary>
        [MaxLength(50)]
        [PropertyMapName("ShiftNameEN")]
        public override string ShiftNameEN
        {
            get { return base.ShiftNameEN; }
            set { base.ShiftNameEN = value; }
        }
        /// <summary>
        /// Gets or sets Shift Name TH.
        /// </summary>
        [MaxLength(50)]
        [PropertyMapName("ShiftNameTH")]
        public override string ShiftNameTH
        {
            get { return base.ShiftNameTH; }
            set { base.ShiftNameTH = value; }
        }

        #endregion
    }
}
