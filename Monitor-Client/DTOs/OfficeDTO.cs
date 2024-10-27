﻿namespace Monitor_Client.DTOs
{
    public class OfficeDTO
    {
        public string? Identificator { get; set; }
        public IList<AttentionPlaceDTO>? AttentionPlaces { get; set; }

        public OfficeDTO(string identificator, IList<AttentionPlaceDTO> attentionPlaces)
        {
            this.Identificator = identificator;
            this.AttentionPlaces = attentionPlaces;
        }

        public OfficeDTO() { }

    }
}