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
    }
}
