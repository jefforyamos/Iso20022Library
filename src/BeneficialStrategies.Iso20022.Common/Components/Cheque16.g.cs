﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque16.  ISO2002 ID# __Pad0V6HEe26aImdqMavcg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics of a cheque instruction, such as cheque type or cheque number.
/// </summary>
public partial record Cheque16
     : IIsoXmlSerilizable<Cheque16>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of cheque to be issued.
    /// </summary>
    public ChequeType2Code? ChequeType { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the agent.
    /// </summary>
    public IsoMax35Text? ChequeNumber { get; init; } 
    /// <summary>
    /// Identifies the party that ordered the issuance of the cheque.
    /// </summary>
    public NameAndAddress16? ChequeFrom { get; init; } 
    /// <summary>
    /// Specifies the delivery method of the cheque by the debtor's agent.
    /// </summary>
    public ChequeDeliveryMethod1Choice_? DeliveryMethod { get; init; } 
    /// <summary>
    /// Party to whom the debtor's agent needs to send the cheque.
    /// </summary>
    public NameAndAddress16? DeliverTo { get; init; } 
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.
    /// </summary>
    public Priority2Code? InstructionPriority { get; init; } 
    /// <summary>
    /// Date when the draft becomes payable and the debtor's account is debited.
    /// </summary>
    public IsoISODate? ChequeMaturityDate { get; init; } 
    /// <summary>
    /// Identifies, in a coded form, the cheque layout, company logo and digitised signature to be used to print the cheque, as agreed between the initiating party and the debtor's agent.
    /// </summary>
    public IsoMax35Text? FormsCode { get; init; } 
    /// <summary>
    /// Information that needs to be printed on a cheque, used by the payer to add miscellaneous information.
    /// </summary>
    public SimpleValueList<IsoMax35Text> MemoField { get; init; } = [];
    /// <summary>
    /// Regional area in which the cheque can be cleared, when a country has no nation-wide cheque clearing organisation.
    /// </summary>
    public IsoMax35Text? RegionalClearingZone { get; init; } 
    /// <summary>
    /// Specifies the print location of the cheque.
    /// </summary>
    public IsoMax35Text? PrintLocation { get; init; } 
    /// <summary>
    /// Signature to be used by the cheque servicer on a specific cheque to be printed.
    /// </summary>
    public SimpleValueList<IsoMax70Text> Signature { get; init; } = [];
    
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
        if (ChequeType is ChequeType2Code ChequeTypeValue)
        {
            writer.WriteStartElement(null, "ChqTp", xmlNamespace );
            writer.WriteValue(ChequeTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChequeNumber is IsoMax35Text ChequeNumberValue)
        {
            writer.WriteStartElement(null, "ChqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ChequeNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ChequeFrom is NameAndAddress16 ChequeFromValue)
        {
            writer.WriteStartElement(null, "ChqFr", xmlNamespace );
            ChequeFromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliveryMethod is ChequeDeliveryMethod1Choice_ DeliveryMethodValue)
        {
            writer.WriteStartElement(null, "DlvryMtd", xmlNamespace );
            DeliveryMethodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DeliverTo is NameAndAddress16 DeliverToValue)
        {
            writer.WriteStartElement(null, "DlvrTo", xmlNamespace );
            DeliverToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InstructionPriority is Priority2Code InstructionPriorityValue)
        {
            writer.WriteStartElement(null, "InstrPrty", xmlNamespace );
            writer.WriteValue(InstructionPriorityValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChequeMaturityDate is IsoISODate ChequeMaturityDateValue)
        {
            writer.WriteStartElement(null, "ChqMtrtyDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(ChequeMaturityDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (FormsCode is IsoMax35Text FormsCodeValue)
        {
            writer.WriteStartElement(null, "FrmsCd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(FormsCodeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "MemoFld", xmlNamespace );
        MemoField.Serialize(writer, xmlNamespace, "Max35Text", SerializationFormatter.IsoMax35Text );
        writer.WriteEndElement();
        if (RegionalClearingZone is IsoMax35Text RegionalClearingZoneValue)
        {
            writer.WriteStartElement(null, "RgnlClrZone", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RegionalClearingZoneValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PrintLocation is IsoMax35Text PrintLocationValue)
        {
            writer.WriteStartElement(null, "PrtLctn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PrintLocationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Sgntr", xmlNamespace );
        Signature.Serialize(writer, xmlNamespace, "Max70Text", SerializationFormatter.IsoMax70Text );
        writer.WriteEndElement();
    }
    public static Cheque16 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
