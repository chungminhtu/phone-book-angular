using System.Collections.Generic;
using PhoneBookDemo.Auditing.Dto;
using PhoneBookDemo.Dto;

namespace PhoneBookDemo.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
