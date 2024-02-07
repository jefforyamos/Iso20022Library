﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OperationMandate3.  ISO2002 ID# _QCGs4Q4fEeK3IMoVvcTkkg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specifying the Mandate.
/// </summary>
public partial record OperationMandate3
     : IIsoXmlSerilizable<OperationMandate3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of change.
    /// </summary>
    public Modification1Code? ModificationCode { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the mandate.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Channel for which the operation mandate is valid. If ApplicableChannel equals Fax, this means that a bank operation instruction sent by fax will be processed according to the mandates exchanged in this message.
    /// </summary>
    public Channel2Choice_? ApplicableChannel { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _qK0XABg3EeKnW4lR85q-0A
    /// <summary>
    /// Number of required and necessary signatures by the mandate.
    /// </summary>
    public required IsoMax15PlusSignedNumericText RequiredSignatureNumber { get; init; } 
    /// <summary>
    /// Indicator whether a certain order of signatures has to be respected or not.
    /// </summary>
    public required IsoYesNoIndicator SignatureOrderIndicator { get; init; } 
    /// <summary>
    /// Holder of the mandate.
    /// </summary>
    public PartyAndAuthorisation3? MandateHolder { get; init; } 
    /// <summary>
    /// Bank operation allowed by a mandate.
    /// </summary>
    public BankTransactionCodeStructure4? BankOperation { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _QYmhcQ4fEeK3IMoVvcTkkg
    /// <summary>
    /// Is the date when the mandate becomes valid.
    /// </summary>
    public IsoISODate? StartDate { get; init; } 
    /// <summary>
    /// Is the date when the mandate stops to be valid.
    /// </summary>
    public IsoISODate? EndDate { get; init; } 
    
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
        if (ModificationCode is Modification1Code ModificationCodeValue)
        {
            writer.WriteStartElement(null, "ModCd", xmlNamespace );
            writer.WriteValue(ModificationCodeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Id", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(Identification)); // data type Max35Text System.String
        writer.WriteEndElement();
        // Not sure how to serialize ApplicableChannel, multiplicity Unknown
        writer.WriteStartElement(null, "ReqrdSgntrNb", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax15PlusSignedNumericText(RequiredSignatureNumber)); // data type Max15PlusSignedNumericText System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SgntrOrdrInd", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(SignatureOrderIndicator)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        if (MandateHolder is PartyAndAuthorisation3 MandateHolderValue)
        {
            writer.WriteStartElement(null, "MndtHldr", xmlNamespace );
            MandateHolderValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        // Not sure how to serialize BankOperation, multiplicity Unknown
        if (StartDate is IsoISODate StartDateValue)
        {
            writer.WriteStartElement(null, "StartDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(StartDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (EndDate is IsoISODate EndDateValue)
        {
            writer.WriteStartElement(null, "EndDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(EndDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static OperationMandate3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
