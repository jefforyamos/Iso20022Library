﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentDateRange1.  ISO2002 ID# _K0tXcdOAEeSQ_-lmj1tzfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies expected and due payment date.
/// </summary>
public partial record PaymentDateRange1
     : IIsoXmlSerilizable<PaymentDateRange1>
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the payment schedule.
    /// </summary>
    public IsoMax35Text? PaymentScheduleIdentification { get; init; } 
    /// <summary>
    /// Expected payment date.
    /// </summary>
    public IsoISODate? ExpectedDate { get; init; } 
    /// <summary>
    /// Latest date whereby the amount must be paid.
    /// </summary>
    public IsoISODate? DueDate { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (PaymentScheduleIdentification is IsoMax35Text PaymentScheduleIdentificationValue)
        {
            writer.WriteStartElement(null, "PmtSchdlId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PaymentScheduleIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ExpectedDate is IsoISODate ExpectedDateValue)
        {
            writer.WriteStartElement(null, "XpctdDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ExpectedDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (DueDate is IsoISODate DueDateValue)
        {
            writer.WriteStartElement(null, "DueDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DueDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static PaymentDateRange1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
