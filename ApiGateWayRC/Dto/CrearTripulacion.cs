using System;

namespace ApiGateWayRC.Dto
{
    public class CrearTripulacion
    {
        public string TripulacionNombre { get; set; }
        public int TripulacionEstado { get; set; }
        public string TripulacionGuid { get; set; }

        public Guid GUID { get; set; }
    }
}
