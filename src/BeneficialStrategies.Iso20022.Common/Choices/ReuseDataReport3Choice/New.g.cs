﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for New.  ISO2002 ID# _0mq3sa4bEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.ReuseDataReport3Choice;

/// <summary>
/// Indicates whether transaction is reported for the first time.
/// </summary>
public partial record New : ReuseDataReport3Choice_
     , IIsoXmlSerilizable<New>
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Date and time of submission of the report to the entitled receiver.
    /// </summary>
    public required IsoISODateTime ReportingDateTime { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required CounterpartyData46 CounterpartyData { get; init; } 
    /// <summary>
    /// Provides the details of the security or cash pledged as collateral.
    /// </summary>
    public CollateralType12? CollateralComponent { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _0qscF64bEemB_csI4yyKLA
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDay { get; init; } 
    /// <summary>
    /// Information on funding sources used to finance margin loans.
    /// </summary>
    public FundingSource1? FundingSource { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        if (TechnicalRecordIdentification is IsoMax140Text TechnicalRecordIdentificationValue)
        {
            writer.WriteStartElement(null, "TechRcrdId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(TechnicalRecordIdentificationValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RptgDtTm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODateTime(ReportingDateTime)); // data type ISODateTime System.DateTime
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CtrPtyData", xmlNamespace );
        CounterpartyData.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        // Not sure how to serialize CollateralComponent, multiplicity Unknown
        writer.WriteStartElement(null, "EvtDay", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(EventDay)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (FundingSource is FundingSource1 FundingSourceValue)
        {
            writer.WriteStartElement(null, "FndgSrc", xmlNamespace );
            FundingSourceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new New Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
