﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.DataTransferObject.DepartmentDto.DepartmentDto
{
    public class CreatedDepartmentDto
    {
        public string Name { get; set; } = null;
        public string Code { get; set; } = null;
        public DateOnly DateOfCreation { get; set; }
        public string? Description { get; set; }

    }
}
