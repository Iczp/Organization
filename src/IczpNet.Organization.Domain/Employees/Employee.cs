using IczpNet.Organization.BaseEntitys;
using IczpNet.Organization.Departments;
using IczpNet.Organization.EmployeePositions;
using IczpNet.Organization.EmployeeStates;
using IczpNet.Organization.EmployeeTypes;
using IczpNet.Organization.Positions;
using IczpNet.Organization.PostGrades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace IczpNet.Organization.Employees
{
    public class Employee : BaseEntity<Guid>
    {
        public virtual Guid? DepartmentId { get; private set; }

        public virtual Guid? EmployeeStateId { get; private set; }

        public virtual Guid? EmployeeTypeId { get; private set; }

        public virtual Guid? PostGradeId { get; private set; }

        //public virtual DateTime? JoinDate { get; set; }

        //public virtual DateTime? FirstJoinDate { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department Department { get; private set; }

        [ForeignKey(nameof(EmployeeStateId))]
        public virtual EmployeeState EmployeeState { get; private set; }

        [ForeignKey(nameof(EmployeeTypeId))]
        public virtual EmployeeType EmployeeType { get; private set; }

        [ForeignKey(nameof(PostGradeId))]
        public virtual PostGrade PostGrade { get; private set; }

        public virtual IList<EmployeePosition> PositionList { get; private set; } = new List<EmployeePosition>();

        public void SetDepartment(Department department)
        {
            Department = department;
        }

        public void SetEmployeeState(EmployeeState employeeState)
        {
            EmployeeState = employeeState;
        }

        public void SetEmployeeType(EmployeeType employeeType)
        {
            EmployeeType = employeeType;
        }

        public void SetPostGrade(PostGrade postGrade)
        {
            PostGrade = postGrade;
        }

        public void SetPositionList(List<Position> positionList)
        {
            PositionList?.Clear();

            foreach (var position in positionList)
            {
                AddPosition(position);
            }
        }

        public void AddPosition(Position position)
        {
            PositionList.Add(new EmployeePosition(this, position));
        }

        public List<Guid> GetPositionIdList()
        {
            return PositionList.Select(x => x.PositionId).ToList();
        }

        public List<Position> GetPositionList()
        {
            return PositionList.Select(x => x.Position).ToList();
        }
    }
}
