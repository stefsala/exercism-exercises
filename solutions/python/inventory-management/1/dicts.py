"""Functions to keep track and alter inventory."""


def create_inventory(items):
    output = {}
    for item in items:
        if item not in output:
            output[item] = items.count(item)
    return output


def add_items(inventory, items):
    output = {}
    for item in items:
        if item in inventory:
            output[item] = inventory[item] + items.count(item)
        else:
            if item not in output:
                output[item] = items.count(item)
    for key in inventory:
        if key not in output:
            output[key] = inventory[key]
    return output


def decrement_items(inventory, items):
    for item in items:
        if (item in inventory) and (inventory[item] > 0):
            inventory[item] -= 1
    return inventory


def remove_item(inventory, item):
    if item in inventory:
        inventory.pop(item)
    return inventory


def list_inventory(inventory):
    lista = []
    for item in inventory:
        if inventory[item] > 0: 
            lista.append((item, inventory[item])) 
    return lista
