﻿using Quality_Management.DTO;

namespace Quality_Management.Model;

public interface IOfficeRepository
{
    public Task<IList<Office>> FindAll();
    public bool ExistsById(string officeId);
    public Office? FindById(string officeId);
    public Office FindByProcedure(long procedureId);
    public Task<OfficeDTO> Save(OfficeDTO office);
    public Task Delete(Office? office);
}