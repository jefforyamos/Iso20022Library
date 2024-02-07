﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _TjY2sZliEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError6Choice;

/// <summary>
/// Reports on reservations.
/// </summary>
public partial record BusinessReport : ReservationOrError6Choice_
     , IIsoXmlSerilizable<BusinessReport>
{
    #nullable enable
    
    /// <summary>
    /// Report is given for a current reservation.
    /// </summary>
    public ReservationReport5? CurrentReservation { get; init; } 
    /// <summary>
    /// Report is given for a default reservation.
    /// </summary>
    public ReservationReport5? DefaultReservation { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (CurrentReservation is ReservationReport5 CurrentReservationValue)
        {
            writer.WriteStartElement(null, "CurRsvatn", xmlNamespace );
            CurrentReservationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DefaultReservation is ReservationReport5 DefaultReservationValue)
        {
            writer.WriteStartElement(null, "DfltRsvatn", xmlNamespace );
            DefaultReservationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new BusinessReport Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
