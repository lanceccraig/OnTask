﻿export function checkBlankEventParent(eventParent) {
    let newEventParent = Object.assign({}, eventParent);
    newEventParent.description = checkBlankReturnNull(eventParent.description);
    newEventParent.weight = checkBlankReturnNull(eventParent.weight);
    return newEventParent;
}

export function checkNullEventParent(eventParent) {
    let newEventParent = Object.assign({}, eventParent);
    newEventParent.description = checkNullReturnBlank(eventParent.description);
    newEventParent.weight = checkNullReturnBlank(eventParent.weight);
    return newEventParent;
}

export function checkBlankEventGroup(eventGroup) {
    let newEventGroup = Object.assign({}, eventGroup);
    newEventGroup.description = checkBlankReturnNull(eventGroup.description);
    newEventGroup.weight = checkBlankReturnNull(eventGroup.weight);
    return newEventGroup;
}

export function checkNullEventGroup(eventGroup) {
    let newEventGroup = Object.assign({}, eventGroup);
    newEventGroup.description = checkNullReturnBlank(eventGroup.description);
    newEventGroup.weight = checkNullReturnBlank(eventGroup.weight);
    return newEventGroup;
}

function checkBlankReturnNull(item) {
    return item === '' ? null : item;
}

function checkNullReturnBlank(item) {
    return item === null ? '' : item;
}
