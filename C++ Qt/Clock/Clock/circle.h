#pragma once

#include <QtWidgets/QWidget>
#include <QtWidgets/QGraphicsItem>
#include <QtGui/QPainter>

class Circle : public QGraphicsItem
{
public:
    Circle();
    QRectF boundingRect() const override;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget) override;
};