"""Functions to keep track and alter inventory."""


def create_inventory(items):
    """
    Function to create an inventory(dict) giving a list of elements.
    The dictionary will have the keys as the list elements and the values will be the elements' number of occurrencies
    """
    output = {}
    for item in items:
        if item not in output:
            output[item] = items.count(item)
    return output


def add_items(inventory, items):
    """
    Adds items to the inventory.
    """
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
    """
    Decreases the value of the specified inventory item(s)
    """
    for item in items:
        if (item in inventory) and (inventory[item] > 0):
            inventory[item] -= 1
    return inventory


def remove_item(inventory, item):
    """
    Removes the inventory item
    """
    if item in inventory:
        inventory.pop(item)
    return inventory


def list_inventory(inventory):
    """
    Returns a list of tuples giving the pair (key,value) of the inventory voices
    """
    lista = []
    for item in inventory:
        if inventory[item] > 0: 
            lista.append((item, inventory[item])) 
    return lista
