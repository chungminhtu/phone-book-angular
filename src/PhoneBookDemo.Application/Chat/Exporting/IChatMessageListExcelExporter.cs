using System.Collections.Generic;
using PhoneBookDemo.Chat.Dto;
using PhoneBookDemo.Dto;

namespace PhoneBookDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(List<ChatMessageExportDto> messages);
    }
}
