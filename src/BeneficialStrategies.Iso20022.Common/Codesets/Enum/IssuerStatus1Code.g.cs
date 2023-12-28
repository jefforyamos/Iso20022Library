﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for IssuerStatus1Code.  ISO2002 ID# _1ss6EDL3EeKU9IrkkToqcw_857646177.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies DTC (The Depository Trust Company) defined issuer status of the event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1ss6EDL3EeKU9IrkkToqcw_857646177")]
[Description(@"Specifies DTC (The Depository Trust Company) defined issuer status of the event.")]
[DerivedFrom(typeof(IssuerStatusCode))]
public enum IssuerStatus1Code
{
    /// <summary>
    /// Event is approved by SEC (Securities and Exchange Commission).
    /// Encoded/decoded by serializers as "ApprovedBySEC".
    /// </summary>
    [EnumMember(Value = "ASEC")]
    [IsoId("_1ss6ETL3EeKU9IrkkToqcw_549706816")]
    [Description(@"Event is approved by SEC (Securities and Exchange Commission).")]
    ApprovedBySEC,
    
    /// <summary>
    /// Event is approved by shareholders.
    /// Encoded/decoded by serializers as "ApprovedByShareholders".
    /// </summary>
    [EnumMember(Value = "ASHH")]
    [IsoId("_1ss6EjL3EeKU9IrkkToqcw_435867750")]
    [Description(@"Event is approved by shareholders.")]
    ApprovedByShareholders,
    
    /// <summary>
    /// Event is approved by SEC (Securities and Exchange Commission and shareholders.
    /// Encoded/decoded by serializers as "ApprovedByShareholdersAndSEC".
    /// </summary>
    [EnumMember(Value = "ASHS")]
    [IsoId("_1ss6EzL3EeKU9IrkkToqcw_1003794085")]
    [Description(@"Event is approved by SEC (Securities and Exchange Commission and shareholders.")]
    ApprovedByShareholdersAndSEC,
    
    /// <summary>
    /// Event has approximate rate.
    /// Encoded/decoded by serializers as "ApproximateRate".
    /// </summary>
    [EnumMember(Value = "APRT")]
    [IsoId("_1ss6FDL3EeKU9IrkkToqcw_1328911592")]
    [Description(@"Event has approximate rate.")]
    ApproximateRate,
    
    /// <summary>
    /// Awaiting information from company on the event.
    /// Encoded/decoded by serializers as "AwaitingInformationFromCompany".
    /// </summary>
    [EnumMember(Value = "AIFC")]
    [IsoId("_1ss6FTL3EeKU9IrkkToqcw_1215072526")]
    [Description(@"Awaiting information from company on the event.")]
    AwaitingInformationFromCompany,
    
    /// <summary>
    /// Event has day grace period.
    /// Encoded/decoded by serializers as "DayGracePeriod".
    /// </summary>
    [EnumMember(Value = "DGRP")]
    [IsoId("_1s2rEDL3EeKU9IrkkToqcw_-1006162773")]
    [Description(@"Event has day grace period.")]
    DayGracePeriod,
    
    /// <summary>
    /// Event distribution was rejected.
    /// Encoded/decoded by serializers as "DistributionRejected".
    /// </summary>
    [EnumMember(Value = "DREJ")]
    [IsoId("_1s2rETL3EeKU9IrkkToqcw_-681045266")]
    [Description(@"Event distribution was rejected.")]
    DistributionRejected,
    
    /// <summary>
    /// Event has free form comments for review.
    /// Encoded/decoded by serializers as "SeeComments".
    /// </summary>
    [EnumMember(Value = "FFCO")]
    [IsoId("_1s2rEjL3EeKU9IrkkToqcw_-794884332")]
    [Description(@"Event has free form comments for review.")]
    SeeComments,
    
    /// <summary>
    /// Holiday in country of origin of the event.
    /// Encoded/decoded by serializers as "HolidayInCountryofOrigin".
    /// </summary>
    [EnumMember(Value = "HOCO")]
    [IsoId("_1s2rEzL3EeKU9IrkkToqcw_396975072")]
    [Description(@"Holiday in country of origin of the event.")]
    HolidayInCountryofOrigin,
    
    /// <summary>
    /// Event issue is not funded.
    /// Encoded/decoded by serializers as "IssueNotFunded".
    /// </summary>
    [EnumMember(Value = "INFN")]
    [IsoId("_1s2rFDL3EeKU9IrkkToqcw_283136006")]
    [Description(@"Event issue is not funded.")]
    IssueNotFunded,
    
    /// <summary>
    /// Event issue is trading flat.
    /// Encoded/decoded by serializers as "IssueTradingFlat".
    /// </summary>
    [EnumMember(Value = "ITFL")]
    [IsoId("_1s2rFTL3EeKU9IrkkToqcw_1448108144")]
    [Description(@"Event issue is trading flat.")]
    IssueTradingFlat,
    
    /// <summary>
    /// Event is a late announcement with elections.
    /// Encoded/decoded by serializers as "LateAnnouncementWithElections".
    /// </summary>
    [EnumMember(Value = "LAWE")]
    [IsoId("_1s2rFjL3EeKU9IrkkToqcw_-395760845")]
    [Description(@"Event is a late announcement with elections.")]
    LateAnnouncementWithElections,
    
    /// <summary>
    /// Event is a liquidation.
    /// Encoded/decoded by serializers as "Liquidation".
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_1s2rFzL3EeKU9IrkkToqcw_-509599911")]
    [Description(@"Event is a liquidation.")]
    Liquidation,
    
    /// <summary>
    /// Event proceeds will be paid upon receipt of funds.
    /// Encoded/decoded by serializers as "PaidUponrReceiptOfFunds".
    /// </summary>
    [EnumMember(Value = "PURF")]
    [IsoId("_1s_1ADL3EeKU9IrkkToqcw_365004308")]
    [Description(@"Event proceeds will be paid upon receipt of funds.")]
    PaidUponrReceiptOfFunds,
    
    /// <summary>
    /// Event processed are pending conversion of funds.
    /// Encoded/decoded by serializers as "PendingConversionOfFunds".
    /// </summary>
    [EnumMember(Value = "PCOF")]
    [IsoId("_1s_1ATL3EeKU9IrkkToqcw_1582093987")]
    [Description(@"Event processed are pending conversion of funds.")]
    PendingConversionOfFunds,
    
    /// <summary>
    /// Event is pending election dividend services elections.
    /// Encoded/decoded by serializers as "PendingEDSElections".
    /// </summary>
    [EnumMember(Value = "PELE")]
    [IsoId("_1s_1AjL3EeKU9IrkkToqcw_1468254921")]
    [Description(@"Event is pending election dividend services elections.")]
    PendingEDSElections,
    
    /// <summary>
    /// Event is pending SEC (Securities and Exchange Commission approval.
    /// Encoded/decoded by serializers as "PendingSECApproval".
    /// </summary>
    [EnumMember(Value = "PSEC")]
    [IsoId("_1s_1AzL3EeKU9IrkkToqcw_-110086210")]
    [Description(@"Event is pending SEC (Securities and Exchange Commission approval.")]
    PendingSECApproval,
    
    /// <summary>
    /// Event is pending SEC (Securities and Exchange Commission and shareholders approval.
    /// Encoded/decoded by serializers as "PendingShareholderAndSECApproval".
    /// </summary>
    [EnumMember(Value = "PSHS")]
    [IsoId("_1s_1BDL3EeKU9IrkkToqcw_344001059")]
    [Description(@"Event is pending SEC (Securities and Exchange Commission and shareholders approval.")]
    PendingShareholderAndSECApproval,
    
    /// <summary>
    /// Event is pending shareholder approval.
    /// Encoded/decoded by serializers as "PendingShareholderApproval".
    /// </summary>
    [EnumMember(Value = "PSHA")]
    [IsoId("_1s_1BTL3EeKU9IrkkToqcw_230161993")]
    [Description(@"Event is pending shareholder approval.")]
    PendingShareholderApproval,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class IssuerStatus1CodeMetadataExtensions
{
    private static readonly IssuerStatus1CodeDropdownSource _dropdownSource = new IssuerStatus1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IIssuerStatus1CodeDropdownRow GetMetadata(this IssuerStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


