window.storageQuota = async () => {
    console.log("storageQuota");

    if ('storage' in navigator && 'estimate' in navigator.storage) {
        const { usage, quota } = await navigator.storage.estimate();
        const percentUsed = Math.round(usage / quota * 100);
        const usageInMib = Math.round(usage / (1024 * 1024));
        const quotaInMib = Math.round(quota / (1024 * 1024));

        const details = `${usageInMib} out of ${quotaInMib} MiB used (${percentUsed}%)`;
        console.log(details);

        return usageInMib;
    }
};
window.storagePersist = async () => {
    if (navigator.storage && navigator.storage.persist) {
        navigator.storage.persist().then(persistent => {
            if (persistent) {
                
                console.log("Storage will not be cleared except by explicit user action");
            } else {
                console.warn("Storage may be cleared by the UA under storage pressure.");
            }
        });
    }
}