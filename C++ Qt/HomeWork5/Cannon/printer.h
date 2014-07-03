#pragma once

#include <QtWidgets/QWidget>
#include <QtWidgets/QGraphicsItem>
#include <QtGui/QPainter>

class Printer : public QGraphicsItem
{
public:
    Printer();
    QRectF boundingRect() const override;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget) override;
};
