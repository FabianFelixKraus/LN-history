﻿
namespace LN_history.Core.Services;

public interface ILightningNetworkAnalyticalService
{
    Task<ICollection<double>> CalculateAllShortestPathCostsByPaymentSizeAndTimestamp(int paymentSizeSat, DateTime timestamp, CancellationToken cancellationToken);
}