export interface InputBareType {
    type: string;
    destinationId: string | null;
    sourceId: string;
    timeCreated: number;
    name: string;
    stringValue: string;
    numericValue: number | null;
    unit: string;
}