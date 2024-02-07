﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMCommand5.  ISO2002 ID# _WHlpIYtvEeSLQutgI1Ulfw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Command result for reinitialization of the transaction counters.
/// </summary>
public partial record ATMCommand5
     : IIsoXmlSerilizable<ATMCommand5>
{
    #nullable enable
    
    /// <summary>
    /// Type of command to be performed by the ATM.
    /// </summary>
    public required ATMCommand3Code Type { get; init; } 
    /// <summary>
    /// Date time on which the command has been requested to be performed.
    /// </summary>
    public IsoISODateTime? RequiredDateTime { get; init; } 
    /// <summary>
    /// Date time on which the command has been performed.
    /// </summary>
    public required IsoISODateTime ProcessedDateTime { get; init; } 
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    /// <summary>
    /// Final result of the processed command at the ATM.
    /// </summary>
    public required TerminalManagementActionResult2Code Result { get; init; } 
    /// <summary>
    /// Additional information on the failure to be logged for further examination.
    /// </summary>
    public IsoMax140Text? AdditionalErrorInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "Tp", xmlNamespace );
        writer.WriteValue(Type.ToString()); // Enum value
        writer.WriteEndElement();
        if (RequiredDateTime is IsoISODateTime RequiredDateTimeValue)
        {
            writer.WriteStartElement(null, "ReqrdDtTm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODateTime(RequiredDateTimeValue)); // data type ISODateTime System.DateTime
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PrcdDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ProcessedDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        if (CommandIdentification is ATMCommandIdentification1 CommandIdentificationValue)
        {
            writer.WriteStartElement(null, "CmdId", xmlNamespace );
            CommandIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Rslt", xmlNamespace );
        writer.WriteValue(Result.ToString()); // Enum value
        writer.WriteEndElement();
        if (AdditionalErrorInformation is IsoMax140Text AdditionalErrorInformationValue)
        {
            writer.WriteStartElement(null, "AddtlErrInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(AdditionalErrorInformationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
    }
    public static ATMCommand5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
